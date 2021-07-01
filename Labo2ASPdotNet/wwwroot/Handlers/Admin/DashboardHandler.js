$(document).ready(() => showListAccount());

const showListAccount = () => {
    $("#dataTables-accountList").hide();
    $("#admin-dashboard-spinner").show();
    $.ajax({
        url: '/Admin/AccountList',
        type: 'GET',
        dataType: 'json',
        success: (data) => {
            $("#dataTables-accountList").show();
            $("#admin-dashboard-spinner").hide();

            
            $.each(data, (index, item) => {
                const classTag = item.isActive ? 'badge-success' : 'badge-secondary';
                let row = "<tr>"
                row += `<td>${item.id}</td>`;
                row += `<td>${item.firstName} ${item.lastName}</td>`;
                row += `<td>${item.email}</td>`;
                row += `<td>${item.username}</td>`;
                row += `<td>${item.accontType === 1 ? 'Admin' : 'User'}</td>`;
                row += `<td>${item.createdAt}</td>`;
                row += `<td><span class="badge ${classTag}">${item.isActive ? 'Actived' : 'Disabled'}</span></td>`;
                row += `<td>
                        <button type="button" class="btn btn-primary" onclick="handleEditUser(${item.id}, ${!item.isActive})"> Update</button >
                        <button type="button" class="btn btn-danger">Delete</button>
                        </td>`;
                $("#datatable-tbody").append(row);
            });
        }
    });
}

const clearDataTable = () => {
    $("#datatable-tbody").empty();
}

async function handleEditUser(id, value) {
    const data = { value };
    const result = await $.ajax({
        url: `/Admin/AccountList/User/${id}`,
        type: 'PUT',
        data
    });
    clearDataTable();
    showListAccount();
};

