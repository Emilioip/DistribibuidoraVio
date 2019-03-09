$(function () {
    $('#txtUser').focus();
    $('#btnRegistrar').on('click', function() {
        var user = $('#txtRegisterUser').val().toLowerCase().trim();
        var pass = $('#txtRegisterPass').val().trim();
        var confirmPass = $('#txtConfirmPass').val();

        if (user==='') {
            alertaErrorLogin('Debes ingresar un nombre de usuario.');
            $('#txtRegisterUser').focus();
            return false;
        }

        if (pass === '') {
            alertaErrorLogin('Debes ingresar una contraseña.');
            $('#txtRegisterPass').focus();
            return false;
        }
        if (!ValidaCaracteres(pass)) {
            alertaErrorLogin('Estas ingresando caracteres invalidos.');
            $('#txtRegisterPass').focus();
            return false;
        }
        if (confirmPass === '') {
            alertaErrorLogin('Debes confirmar la contraseña.');
            $('#txtConfirmPass').focus();
            return false;
        }

        if (pass !== confirmPass) {
        alertaErrorLogin('La contraseña y confirmacion no coinciden.');
        $('#txtConfirmPass').focus();
        return false;
        }


        proxy_login.registro(user, pass);

    });

        $('#txtConfirmPass').on('keypress', function () {
            var keyCode = (event.keyCode ? event.keyCode : event.which);
            if (keyCode == 13) {
                $('#btnRegistrar').focus();
            }
        });
    $('#txtUser').on('keypress', function () {
        var keyCode = (event.keyCode ? event.keyCode : event.which);
        if (keyCode == '13') {
            onload('');
        }
    });

    $('#txtPass').on('keypress', function () {
        var keyCode = (event.keyCode ? event.keyCode : event.which);
        if (keyCode == '13') {
            javascript: __doPostBack('btnIngresar', '');
        }
    });
});

function limpiar() {
    $('#txtRegisterUser').val('');
    $('#txtRegisterPass').val('');
    $('#txtConfirmPass').val('');
}

function alertifyMessageLogin(text) {
    try {
        swal({ title: "Registro exitoso.", text: text, type: "success", allowOutsideClick: false })
    }
    catch (err) {
        alert('Error: ' + text);
    }
}

function alertaErrorLogin(text) {
    try {
        alertify.error(text);
    }
    catch (err) {
        alert('Error: ' + text);
    }
}

