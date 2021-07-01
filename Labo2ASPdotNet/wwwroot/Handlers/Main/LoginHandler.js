$(document).ready(() => {
    const token = localStorage.getItem('token');
    if (token) {
        window.location.href = '/Dashboard';
    }
    $('#alert').hide();
    $('#user-login-spinner').hide();
});

const handleLogin = async () => {
    const username = $('#user-input-username').val();
    const password = $('#user-input-password').val();
    const data = { username, password };
    $('#user-login-spinner').show();
    $('#alert').hide();
    try {
        $('#alert').hide();
        const result = await $.ajax({
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            url: '/Api/Users/Login',
            type: 'POST',
            dataType: 'json',
            data: JSON.stringify(data)
        });
        if (!result) {
            $('#alert').show();
            $('#user-login-spinner').hide();
            return;
        }
        localStorage.setItem('token', result.token);
        localStorage.setItem('username', result.username);
        localStorage.setItem('email', result.email);
        localStorage.setItem('admin', result.accontType);
        localStorage.setItem('userId', result.id);
        window.location.href = '/Dashboard';
    } catch (err) {
        $('#alert').show();
    } finally {
        $('#user-login-spinner').hide();
    }
};
