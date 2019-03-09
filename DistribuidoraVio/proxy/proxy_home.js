var proxy_home = new Proxy_Home();

function Proxy_Home() {
    this.TraerDatos = function TraerDatos(usuario) {
        var data = JSON.stringify({ user: usuario });


        $.ajax({
            url: "Home.aspx/TraerDatos",
            data: data,
            dataType: "json",
            type: "post",
            cache: false,
            contentType: "application/json; charset=utf-8",
            success: function (response) {
                var a = response.d;
                var r = a.values[0];
                console.log(a);
                alertifyMessageLogin("En hora buena ID: " + a.values[0].Id + " ");

            },
            error: function () {
                alert("Ha ocurrido un error desde el proxy.")
            }
        });
    }
    this.getProductos = function getProductos() {
        $.ajax({
            url: "Home.aspx/Prueba",
            dataType: "json",
            type: "post",
            contentType: "application/json; charset=utf-8",
            cache: false
        }).done(function (response) {
            var r = response.d;


            if (r.ret == "OK") {
                alert("");
                var mes = response.d.values;
                console.log(mes);
                //$('options', cboMeses).remove();
                optMes[optMes.length] = new Option('Seleccione ...', '0');
                $.each(mes, function (i, v) {
                    optMes[optMes.length] = new Option (v.Mes, v.IdMes);
                });
                $('#cboMeses option[value="0"]').attr("selected", true);

            }
        }).fail(function () {
            alert("fail");
        });
    }
    this.llenarCombo2 = function llenarCombo2() {

       
        var grupore = $("#cboGrupoResolutor");
        var optgru = null;

        optgru = grupore.attr('options');
        if (grupore.prop)
            optgru = grupore.prop('options');

        $.ajax({
            url: "Home.aspx/llenarCombo",
            dataType: "json",
            type: "post",
            contentType: "application/json; charset=utf-8",
            cache: false
        }).done(function (response) {
            var r = response.d;


            if (r.ret == "OK") {
                var mes = response.d.values;
                
                $('options', grupore).remove();
                optgru[optgru.length] = new Option('Seleccione ...', '0');
                $.each(mes, function (i, v) {
                    optgru[optgru.length] = new Option(v.Mes, v.IdMes);
                });


            }
        }).fail(function () {
            alert("fail");
        });
    }
    this.getCodigo = function getCodigo(codigo) {

        var values = JSON.stringify({ codigo: codigo });

        $.ajax({
            url: "Home.aspx/getCodigo",
            data: values,
            type: "post",
            cache: false,
            dataType: "json",
            contentType: "application/json; charset=utf8"
        }).done(function (response) {
            var r = response.d;
            if (r.ret == "OK") {
                $('#txtNameProduct').val(r.msg);
            } else {
                $('#txtNameProduct').val('');
            }
            }).fail(function () {
            });

    }
}