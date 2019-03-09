var proxy_login = new Proxy_Login();

function Proxy_Login() {
    this.prueba = function prueba(usuario, clave) {

        var data = {
            usuario: {
                User : usuario,
                Pass : clave
            }
        }

        $.ajax({
            url: "Login.aspx/Prueba",
            method: "POST",
            data: JSON.stringify(data),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (response) {
                var r = response.d;

                if (r.ret === "OK") {
                    alertifyMessageLogin(r.msg);
                    location.href = "Home.aspx";
                } else {
                    alertaErrorLogin(r.msg);
                }
            }, error: function (response) {
                var r = response.d
                    alertaErrorLogin(r.msg);
                }

        })
    }

    this.registro = function registro(user, pass) {
        var data = {
            nuevoRegistro: {
                User: user,
                Pass: pass
            }
        }
        $.ajax({
            url: "Login.aspx/CrearUsuario",
            data: JSON.stringify(data),
            cache: false,
            type:'post',
            dataType: 'json',
            contentType: 'application/json; charset=utf-8',
            success: function (response) {
                var a = response.d;

                if (a.ret === 'OK') {
                    alertifyMessageLogin("Se ha registrado " + user + " con exito.");
                    limpiar();
                }
            },
            error: function () {
                alertaErrorLogin('Se ha producido un error');
            }
        });
    }
}