$("#data-top-product").hide();
$("#new-products-spinner").show();
let selectedProduct = null;

$(document).ready(() => {
    showListTopProduct();
});

const showListTopProduct = async () => {
    $("#data-top-product").hide();
    $("#create-spinner").hide();
    $("#new-products-spinner").show();
    $('#admin-top-product-issue').hide();
    try {
        const products = await $.ajax({
            url: '/api/products/NewProducts',
            type: 'GET',
            dataType: 'json'
        })

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
    } finally {
        $("#new-products-spinner").hide();
        $("#data-top-product").show();
    }
}

const cleanDataProductTable = () => {
    $("#datatable-product-tbody").empty();
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
    }
};