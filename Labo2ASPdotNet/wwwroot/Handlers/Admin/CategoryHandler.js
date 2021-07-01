$("#dataTables-categoriesList").hide();
$("#product-pagination-wrapper").hide();

let selectedCategoryId = null;

$(document).ready(() => {
    showListCategory();
});

const showListCategory = async() => {
    $("#dataTables-categoriesList").hide();
    $("#create-spinner").hide();
    $("#admin-categories-spinner").show();
    try {
        const categories = await $.ajax({
            url: '/api/categories',
            type: 'GET',
            dataType: 'json'
        });

        categories.forEach(category => {
            let row = "<tr>";
            row += `<td>${category.id}</td>`;
            row += `<td>${category.name}</td>`;
            row += `<td>${category.createdAt}</td>`;
            row += `<td>
                        <button id="update-button-${category.id}" type="button" class="btn btn-primary">Update</button>
                        <button id="delete-button-${category.id}" type="button" class="btn btn-danger">Delete</button>
                        </td>`;
            $("#datatable-category-tbody").append(row);

            $(`#update-button-${category.id}`).on("click", { category }, openCategoryModalUpdate);
            $(`#delete-button-${category.id}`).on("click", { category }, openCategoryModalDelete);

        });
    } finally {
        $("#dataTables-categoriesList").show();
        $("#admin-categories-spinner").hide();
    }
}


const cleanDataCategoryTable = () => {
    $("#datatable-category-tbody").empty();
}

async function handleCreateCategory() {
    const name = $("#nameCategoryCreate").val();
    
    $("#create-spinner").show();

    const data = {
        name
    };

    try {
        await $.ajax({
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            dataType: 'json',
            url: `/Api/Categories`,
            type: 'POST',
            data: JSON.stringify(data)
        });
    } catch (e) {
        console.log(e);
    } finally {
        $("#create-spinner").hide();
        $("#create-categories-modal").modal('hide');
    }

    cleanDataCategoryTable();
    showListCategory();    
    $("#nameCategoryCreate").val("");
}

function openCategoryModalUpdate(event) {
    const { category: { id, name } } = event.data;
    selectedCategoryId = id;
    $("#update-category-modal").modal('show');
    $("#update-spinner").hide();

    $("#nameCategoryUpdate").val(name);
}

function openCategoryModalDelete(event) {
    const { category } = event.data;
    selectedCategoryId = category.id;

    $("#delete-category-modal").modal('show');
    $("#delete-spinner").hide();
}

async function handleUpdateCategory() {
    try {
        const category = {
            name: $("#nameCategoryUpdate").val()
        };

        $("#update-spinner").show();

        await $.ajax({
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            dataType: 'json',
            url: `/Api/Categories/${selectedCategoryId}`,
            type: 'PUT',
            data: JSON.stringify(category)
        });

    } catch (e) {
        console.error(e);
    } finally {

        $("#update-spinner").hide();
        cleanDataCategoryTable();
        showListCategory();

        $("#update-category-modal").modal('hide');
    }

}

async function handleDeleteCategory() {
    try {
        $("#delete-spinner").show();

        await $.ajax({
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            dataType: 'json',
            url: `/Api/Categories/${selectedCategoryId}`,
            type: 'DELETE'
        });
    }
    finally {
        $("#delete-spinner").hide();
        cleanDataCategoryTable();
        showListCategory();

        $("#delete-category-modal").modal('hide');
    }
}
