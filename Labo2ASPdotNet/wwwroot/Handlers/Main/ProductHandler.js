$("#data-top-product").hide();
$("#new-products-spinner").show();
let selectedProduct = null;

$(document).ready(() => {
    showListProduct("");
});

const showListProduct = async (link) => {
    $("#data-top-product").hide();
    $("#create-spinner").hide();
    $("#new-products-spinner").show();
    $('#admin-top-product-issue').hide();
    $('#order-alert').hide();

    try {
        const data = await $.ajax({
            url: link || '/api/products?PageNumber=1&PageSize=10',
            type: 'GET',
            dataType: 'json'
        })

        // Handle render pagination
        const paginationElement = $("#products-pagination");
        paginationElement.empty();
        const prevLink = (data.previousPage || data.firstPage).substr(22);
        const nextLink = (data.nextPage || data.lastPage).substr(22);

        paginationElement.append(`<li id="pagination-prev" class="page-item"><button class="page-link" tabindex="-1">Previous</a></li>`);
        $(`#pagination-prev`).on("click", { link: prevLink }, handleClickPagination);

        for (let i = 0; i < data.totalPages; i++) {
            let link = `/Api/Products?PageNumber=${i + 1}&PageSize=10`;
            paginationElement.append(`<li id="pagination-${i + 1}"  class="page-item ${i + 1 === data.pageNumber && 'active'}"><button class="page-link" tabindex="-1">${i + 1}</a></li>`)
            $(`#pagination-${i + 1}`).on("click", { link }, handleClickPagination);
        }

        paginationElement.append(`<li id="pagination-next" class="page-item"><button class="page-link" tabindex="-1">Next</a></li>`);
        $(`#pagination-next`).on("click", { link: nextLink }, handleClickPagination);
        $("#product-pagination-wrapper").show();

        // handle show list product

        data.data.forEach(product => {
            let card = `<div class="card col-xs-3 col-sm-4">`;
            card += `<img src="${product.url}" class="card-img-top" alt="product-image">`;
            card += `<div class="card-body">`;
            card += `<h4 class="card-title">${product.name}</h4>`;
            card += `<p class="card-text">${product.description}</p>`;
            card += `<h4 class="card-title">${product.price} Đồng</h4>`;
            card += `<button id="buy-btn-${product.id}" type="button" class="btn btn-primary">Buy</a>`;
            card += `</div></div>`;
            $('#data-top-product').append(card);
            $(`#buy-btn-${product.id}`).on("click", { product }, openBuyProductModal);
        });
    } finally {
        $("#new-products-spinner").hide();
        $("#data-top-product").show();
        $("#product-pagination-wrapper").show();
    }
}

const cleanDataProductTable = () => {
    $("#data-top-product").empty();
}

function openBuyProductModal(event) {
    const { product } = event.data;
    console.log('event', event.data.product);
    selectedProduct = product;

    $("#buy-products-modal").modal('show');
    $("#buy-spinner").hide();

    $("#nameProductBuy").val(product.name);
    $("#priceProductBuy").val(product.price);
}

const handleBuyProduct = async () => {
    $('#admin-top-product-issue').hide();
    const token = localStorage.getItem('token');
    const data = {
        OrderItemList: [{
            productId: selectedProduct.id,
            price: selectedProduct.price,
            quantity: $('#quantityProductBuy').val()
        }]
    };
    $("#buy-spinner").show();
    try {
        await $.ajax({
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json',
                'Authorization': `Bearer ${token}`
            },
            dataType: 'json',
            url: `/Api/orders`,
            type: 'POST',
            data: JSON.stringify(data)
        });
    } catch (err) {
        if (err.statusText !== 'OK') {
            $('#admin-top-product-issue').show();
        }
    } finally {
        $("#buy-spinner").hide();
        $("#buy-products-modal").modal('hide');

        $('#order-alert').show();
        setTimeout(() => {
            $('#order-alert').hide();
        },2000)
    }
};


function handleClickPagination(event) {
    console.log(event);
    const { link } = event.data;
    cleanDataProductTable();
    showListProduct(link);
}


const handleSearchProductByName = async () => {
    const searchInput = $('#inputSearchProductName').val();

    $('#data-top-product').hide();

    $("#dataTables-productList").hide();
    const paginationElement = $("#products-pagination");
    paginationElement.empty();
    $("#product-pagination-wrapper").hide();
    cleanDataProductTable();

    $("#new-products-spinne").show();
    const products = await $.ajax({
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        dataType: 'json',
        url: `/Api/Products/Name?productName=${searchInput}`,
        type: 'GET',
    });

    products.forEach(product => {
        let card = `<div class="card col-xs-3 col-sm-4">`;
        card += `<img src="${product.url}" class="card-img-top" alt="product-image">`;
        card += `<div class="card-body">`;
        card += `<h4 class="card-title">${product.name}</h4>`;
        card += `<p class="card-text">${product.description}</p>`;
        card += `<h4 class="card-title">${product.price} Đồng</h4>`;
        card += `<button id="buy-btn-${product.id}" type="button" class="btn btn-primary">Buy</a>`;
        card += `</div></div>`;
        $('#data-top-product').append(card);
        $(`#buy-btn-${product.id}`).on("click", { product }, openBuyProductModal);
    });
    $("#new-products-spinner").hide();
    $("#data-top-product").show();
    
};

const resetSearch = () => {
    showListProduct("");
    cleanDataProductTable();
    $('#inputSearchProductName').val("");
}
