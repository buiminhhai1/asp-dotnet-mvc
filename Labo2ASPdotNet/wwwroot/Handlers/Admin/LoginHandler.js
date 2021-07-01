$(document).ready(() => {
    const token = localStorage.getItem('token');
    if (token) {
        window.location.href = '/Admin/Dashboard';
    }
    $('#admin-login-spinner').hide();
    $('#admin-login-issue').hide();
});

const handleLogin = async () => {
    const username = $('#admin-username-login').val();
    const password = $('#admin-password-login').val();
    const data = { username, password };
    $('#admin-login-spinner').show();
    $('#admin-login-issue').hide();
    try {
        const result = await $.ajax({
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            url: '/Api/Admin/Login',
            type: 'POST',
            dataType: 'json',
            data: JSON.stringify(data)
        });
        if (!result) {
            $('#admin-login-issue').show();
            $('#admin-login-spinner').hide();
            return;
        }
        localStorage.setItem('token', result.token);
        localStorage.setItem('username', result.username);
        localStorage.setItem('email', result.email);
        localStorage.setItem('admin', result.accontType);
        window.location.href = '/Admin/Dashboard';
    } catch (err) {
        $('#admin-login-issue').show();
    } finally {
        $('#admin-login-spinner').hide();
    }
};
