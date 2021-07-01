const ORDER_STATUS = {
    0: 'Pending',
    1: 'InProgress',
    2: 'Completed'
};

$("#dataTables-orderList").hide();
$("#order-pagination-wrapper").hide();

let selectedOrder = null;

$(document).ready(() => {
    showListOrder("");
});

const showListOrder = async (link) => {
    $("#dataTables-orderList").hide();
    $("#create-spinner").hide();
    $("#admin-orders-spinner").show();
    try {
        const data = await $.ajax({
            url: link || '/api/orders?PageNumber=1&PageSize=10',
            type: 'GET',
            dataType: 'json',
        });
        $("#dataTables-orderList").show();
        $("#admin-orders-spinner").hide();

        // Handle render pagination
        const paginationElement = $("#orders-pagination");
        paginationElement.empty();
        const prevLink = (data.previousPage || data.firstPage).substr(22);
        const nextLink = (data.nextPage || data.lastPage).substr(22);

        paginationElement.append(`<li id="pagination-prev" class="page-item"><button class="page-link" tabindex="-1">Previous</a></li>`);
        $(`#pagination-prev`).on("click", { link: prevLink }, handleClickPagination);

        for (let i = 0; i < data.totalPages; i++) {
            let link = `/Api/orders?PageNumber=${i + 1}&PageSize=10`;
            paginationElement.append(`<li id="pagination-${i + 1}"  class="page-item ${i + 1 === data.pageNumber && 'active'}"><button class="page-link" tabindex="-1">${i + 1}</a></li>`)
            $(`#pagination-${i + 1}`).on("click", { link }, handleClickPagination);
        }

        paginationElement.append(`<li id="pagination-next" class="page-item"><button class="page-link" tabindex="-1">Next</a></li>`);
        $(`#pagination-next`).on("click", { link: nextLink }, handleClickPagination);
        $("#order-pagination-wrapper").show();

        // Handle show list product

        data.data.forEach(order => {
            let row = "<tr>"
            row += `<td>${order.id}</td>`;
            row += `<td>${ORDER_STATUS[order.status]}</td>`;
            row += `<td>${order.user.username}</td>`;
            row += `<td>${order.orderItems[0].product.id}</td>`;
            row += `<td><img src="${order.orderItems[0].product.url}" alt="image" width="80"/></td>`;
            row += `<td>${order.orderItems[0].product.name}</td>`;
            row += `<td>${order.orderItems[0].quantity}</td>`;
            row += `<td>${order.orderItems[0].priceInvoice} Đồng</td>`;
            row += `<td>${order.orderItems[0].quantity * order.orderItems[0].priceInvoice} Đồng</td>`;
            row += `<td>${order.createdAt}</td>`;
            row += `<td>
                    <button id="update-button-${order.id}" type="button" class="btn btn-primary">Update Status</button>
                    </td>`;
            $("#datatable-order-tbody").append(row);

            $(`#update-button-${order.id}`).on("click", { order }, openOrderModalUpdate);
        });
    } catch (err) {
        console.log(err);
    } finally {
        $("#dataTables-orderList").show();
        $("#order-pagination-wrapper").show();
        $("#admin-orders-spinner").hide();
    }
}


const cleanDataOrderTable = () => {
    $("#datatable-order-tbody").empty();
}

function openOrderModalUpdate(event) {
    const { order } = event.data;
    selectedOrder = order;
    $("#update-order-modal").modal('show');
    $("#update-spinner").hide();

    $("#idOrder").val(order.id);
    $('#statusOrder').val(ORDER_STATUS[order.status]);
}

async function handleUpdateStatusOrder() {
    try {
        const orderId = selectedOrder.id;
        const status = $('#statusOrder').val();

        $("#update-spinner").show();

        await $.ajax({
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            dataType: 'json',
            url: `/Api/orders/${orderId}/status/${status}`,
            type: 'PATCH',
        });

        $("#update-spinner").hide();
        cleanDataOrderTable();
        showListOrder();

        $("#update-order-modal").modal('hide');
    } catch (e) {
        if (e.statusText !== 'OK') {

            $("#update-spinner").hide();
            $("#update-order-modal").modal('hide');
        }
    } finally {

        $("#update-spinner").hide();
        cleanDataOrderTable();
        showListOrder();

        $("#update-order-modal").modal('hide');
    }

}

function handleClickPagination(event) {
    const { link } = event.data;
    cleanDataOrderTable();
    showListOrder(link);
}