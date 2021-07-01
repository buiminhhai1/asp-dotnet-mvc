$("#dataTables-productList").hide();
$("#product-pagination-wrapper").hide();
let selectedProductId = null;

$(document).ready(() => {
    showListProduct("");
    getCategories();
});

const showListProduct = (link) => {
    $("#dataTables-productList").hide();
    $("#create-spinner").hide();
    $("#admin-products-spinner").show();
    $.ajax({
        url: link || '/api/products?PageNumber=1&PageSize=10',
        type: 'GET',
        dataType: 'json',
        success: (data) => {
            $("#dataTables-productList").show();
            $("#admin-products-spinner").hide();

            // Handle render pagination
            const paginationElement = $("#products-pagination");
            paginationElement.empty();
            const prevLink = (data.previousPage || data.firstPage).substr(22);
            const nextLink = (data.nextPage || data.lastPage).substr(22);

            paginationElement.append(`<li id="pagination-prev" class="page-item"><button class="page-link" tabindex="-1">Previous</a></li>`);
            $(`#pagination-prev`).on("click", { link: prevLink }, handleClickPagination);

            for (let i = 0; i < data.totalPages; i++) {
                let link = `/Api/Products?PageNumber=${i+1}&PageSize=10`;
                paginationElement.append(`<li id="pagination-${i + 1}"  class="page-item ${i + 1 === data.pageNumber && 'active'}"><button class="page-link" tabindex="-1">${i + 1}</a></li>`)
                $(`#pagination-${i + 1}`).on("click", { link }, handleClickPagination);
            }

            paginationElement.append(`<li id="pagination-next" class="page-item"><button class="page-link" tabindex="-1">Next</a></li>`);
            $(`#pagination-next`).on("click", { link: nextLink }, handleClickPagination);
            $("#product-pagination-wrapper").show();

            // Handle show list product
            $.each(data.data, (index, item) => {
                let row = "<tr>"
                row += `<td>${item.id}</td>`;
                row += `<td><img src="${item.url}" alt="image" width="80"/></td>`;
                row += `<td>${item.name}</td>`;
                row += `<td>${item.price} Đồng</td>`;
                row += `<td>${item.quantity}</td>`;
                row += `<td>${item.category.name}</td>`;
                row += `<td>${item.description}</td>`;
                row += `<td>${item.createdAt}</td>`;
                row += `<td>
                        <button id="update-button-${item.id}" type="button" class="btn btn-primary">Update</button>
                        <button id="delete-button-${item.id}" type="button" class="btn btn-danger">Delete</button>
                        </td>`;
                $("#datatable-product-tbody").append(row);

                $(`#update-button-${item.id}`).on("click", { product: item }, openProductModalUpdate);
                $(`#delete-button-${item.id}`).on("click", { productId: item.id }, openProductModalDelete);
            });
        },
        error: () => {
            $("#dataTables-productList").show();
            $("#product-pagination-wrapper").show();
            $("#admin-products-spinner").hide();
        }
    });
}



const getCategories = async () => {
    const categories = await $.ajax({
        url: '/api/categories',
        type: 'GET',
        dataType: 'json'
    });
    $('#categoryProductCreate').empty();
    $('#categoryProductUpdate').empty();

    categories.forEach(item => {
        let options = `<option value="${item.id}">${item.name}</option>`;
        $('#categoryProductCreate').append(options);
        $('#categoryProductUpdate').append(options);
    });

};

const cleanDataProductTable = () => {
    $("#datatable-product-tbody").empty();
}

async function handleCreateProduct() {
    const name = $("#nameProductCreate").val();
    const price = $("#priceProductCreate").val();
    const quantity = $("#quantityProductCreate").val();
    const categoryId = $("#categoryProductCreate").val();
    const url = $("#imageProductCreate").val();
    const description = $("#descriptionProductCreate").val();

    $("#create-spinner").show();

    const data = {
        name,
        price,
        quantity,
        url,
        description,
        categoryId
    };

    try {
        await $.ajax({
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            dataType: 'json',
            url: `/Api/Products`,
            type: 'POST',
            data: JSON.stringify(data)
        });
    } catch (e) {
        $("#create-spinner").hide();
        $("#create-products-modal").modal('hide');   
    }
    


    $("#create-spinner").hide();
    cleanDataProductTable();
    showListProduct();

    $("#create-products-modal").modal('hide');
    $("#nameProductCreate").val("");
    $("#priceProductCreate").val(0);
    $("#quantityProductCreate").val(1);
    $("#imageProductCreate").val("");
    $("#descriptionProductCreate").val("");
}

function openProductModalUpdate(event) {
    const { product: { id, name, price, quantity, category, url, description } } = event.data;
    selectedProductId = id;
    $("#update-products-modal").modal('show');
    $("#update-spinner").hide();

    $("#nameProductUpdate").val(name);
    $("#priceProductUpdate").val(price);
    $("#quantityProductUpdate").val(quantity);
    $("#categoryProductUpdate").val(category.id);
    $("#imageProductUpdate").val(url);
    $("#descriptionProductUpdate").val(description);
}

function openProductModalDelete(event) {
    const { productId } = event.data;
    selectedProductId = productId;

    $("#delete-products-modal").modal('show');
    $("#delete-spinner").hide();
}

async function handleUpdateProduct() {
    try {
        const product = {
            name: $("#nameProductUpdate").val(),
            price: $("#priceProductUpdate").val(),
            quantity: $("#quantityProductUpdate").val(),
            categoryId: $("#categoryProductUpdate").val(),
            url: $("#imageProductUpdate").val(),
            description: $("#descriptionProductUpdate").val()
        };

        $("#update-spinner").show();

        await $.ajax({
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            dataType: 'json',
            url: `/Api/Products/${selectedProductId}`,
            type: 'PUT',
            data: JSON.stringify(product)
        });
       
    } catch (e) {
        console.error(e);
    } finally {

        $("#update-spinner").hide();
        cleanDataProductTable();
        showListProduct();

        $("#update-products-modal").modal('hide');  
    }
    
}

async function handleDeleteProduct() {
    try {
        $("#delete-spinner").show();

        await $.ajax({
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            dataType: 'json',
            url: `/Api/Products/${selectedProductId}`,
            type: 'DELETE'
        });
    }
    finally {
        $("#delete-spinner").hide();
        cleanDataProductTable();
        showListProduct();

        $("#delete-products-modal").modal('hide');  
    }
}

function handleClickPagination(event) {
    const { link } = event.data;
    cleanDataProductTable();
    showListProduct(link);
}

const handleSearchProductByName = async () => {
    const searchInput = $('#inputSearchProductName').val();

    $("#dataTables-productList").hide();
    const paginationElement = $("#products-pagination");
    paginationElement.empty();

    cleanDataProductTable();

    $("#admin-products-spinner").show();
    const products = await $.ajax({
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        dataType: 'json',
        url: `/Api/Products/Name?productName=${searchInput}`,
        type: 'GET',
    });
    
    products.forEach(item => {
        let row = "<tr>"
        row += `<td>${item.id}</td>`;
        row += `<td><img src="${item.url}" alt="image" width="80"/></td>`;
        row += `<td>${item.name}</td>`;
        row += `<td>${item.price} Đồng</td>`;
        row += `<td>${item.quantity}</td>`;
        row += `<td>${item.category.name}</td>`;
        row += `<td>${item.description}</td>`;
        row += `<td>${item.createdAt}</td>`;
        row += `<td>
                        <button id="update-button-${item.id}" type="button" class="btn btn-primary">Update</button>
                        <button id="delete-button-${item.id}" type="button" class="btn btn-danger">Delete</button>
                        </td>`;
        $("#datatable-product-tbody").append(row);

        $(`#update-button-${item.id}`).on("click", { product: item }, openProductModalUpdate);
        $(`#delete-button-${item.id}`).on("click", { productId: item.id }, openProductModalDelete);
    });
    $("#admin-products-spinner").hide();
    $("#dataTables-productList").show();
};

const resetSearch = () => {
    showListProduct("");
    cleanDataProductTable();
    $('#inputSearchProductName').val("");
}
