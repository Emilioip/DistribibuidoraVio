$(function () {
    
    $('#menuPrincipal a').click(function () {
        $('#menuPrincipal a').removeClass('active');
        $(this).addClass('active');
    });

    $('#txtCodigo').keyup(function () {
        var codigo = $('#txtCodigo').val();
        proxy_home.getCodigo(codigo);
    });

    $('#btnEnviar').click(function () {
       
        var nomPro = $('#txtNameProduct').val();
        var cod = $('#txtCodigo').val();
        if (cod == '') {
            alert("Debes ingresar un codigo de barra");
            $('#txtCodigo').focus();
            return false;
        }
       
        if (nomPro == '') {
            alert("No hay un producto asociado a ese codigo de barra");
            $('#txtCodigo').focus();
            return false;
        }
        alert("En hora buena");
    });
    $('#btnTraerDatos').on('click', function () {

  

        var usuario = new Usuarios();
        usuario.User = "emilio";
        usuario.Pass = "";

        proxy_home.TraerDatos(usuario);
    })


    $("#btnCerrarSesion").click(function () {
        sessionStorage.clear();
        $(location).attr('href', 'Login.aspx');
    });
    
        $(window).load(function () {

            setTimeout(function () {

                $(".loader").fadeOut("slow");
            },1000)
        });
});
