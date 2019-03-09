<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="Content/estilos.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery.unobtrusive-ajax.js"></script>
    <script src="Scripts/jquery.unobtrusive-ajax.min.js"></script>
    <!-- ALERTIFY -->
    <!--[if lt IE 9]>
        <link rel="stylesheet" href="./plugins/alertify/css/alertify.css" />
        <link rel="stylesheet" href="./plugins/alertify/css/default.css" />
        <script type="text/javascript" src="./plugins/alertify/alertify.js"></script>
		<![endif]-->
    <!--[if (gte IE 9) | (!IE)]><!-->
    <link rel="stylesheet" href="./plugins/alertify/css/alertify.css" />
    <link rel="stylesheet" href="./plugins/alertify/css/default.css" />
    <link href="Content/stylo.css" rel="stylesheet" />
    <script type="text/javascript" src="./plugins/alertify/alertify.js"></script>
    <!--<![endif]-->
    <!-- /ALERTIFY -->

    <script src="plugins/sweetalert/core.js"></script>
    <script src="plugins/sweetalert/sweetalert2.all.js"></script>

    <script src="proxy/proxy_login.js"></script>
    <script src="Scripts/Utils.js"></script>
    <script src="Scripts/login.js"></script>
</head>
<body id="fondoLogin" class="body">
    <div class="container">
        <form id="form1" runat="server" class="col-sm-offset-3 col-sm-6">
            <div>
                <div class="text-center">
                    <h4>Inicio de Sesión</h4>
                </div>
                <br />
                <div class="input-group">
                    <div class="input-group-addon">
                        <span class="glyphicon glyphicon-user"></span>
                    </div>
                    <input type="text" id="txtUser" placeholder="Ingrese Usuario" class="form-control" runat="server" />
                </div>
                <br />
                <div class="input-group">
                    <div class="input-group-addon">
                        <span class="glyphicon glyphicon-lock"></span>
                    </div>
                    <input type="password" id="txtPass" class="form-control" placeholder="Ingrese Password" runat="server" />
                </div>
                <br />
                <div class="btn-group">
                    <asp:LinkButton CssClass="btn btn-success" ID="btnIngresar" runat="server" OnClick="Login" Text="Ingresar"></asp:LinkButton>
                    <input class="btn btn-info" data-toggle="modal" value="registrarme" data-target="#register" type="button" />
                </div>
            </div>
        </form>
    </div>
    <label id="msj" runat="server"></label>
    <div class="modal fade" id="register" tabindex="-1" role="dialog">
        <div class="modal-dialog" role="document">
            <form>
                <div class="panel panel-primary">
                    <div class="panel-heading text-center">
                        <h4>Registro de usuario</h4>
                    </div>
                    <div class="panel-body">
                        <input type="text" id="txtRegisterUser" placeholder="Nombre de usuario" class="form-control" />
                        <br />
                        <input type="password" id="txtRegisterPass" placeholder="Contraseña" class="form-control" />
                        <br />
                        <input type="password" id="txtConfirmPass" placeholder="Confirmar Contraseña" class="form-control" />
                        <br />
                        <div class="text-muted">
                            <p>La contraseña debe contener solo lo siguiente:</p>
                            <p>- Numeros.</p>
                            <p>- Letras mayusculas y/o minusculas.</p>
                            <p>- Caracteres especiales permitidos puntos (.), arrobas (@) y/o signo (!)</p>
                        </div>
                    </div>
                    <div class="panel-footer">
                        <div class="col-sm-offset-10">
                            <input type="button" value="Registrar" id="btnRegistrar" class="btn btn-info" data-dismiss="modal" />
                        </div>
                    </div>
                </div>
            </form>
        </div>
    </div>
    <br />
    <div id="ret" runat="server">

    </div>
</body>
</html>
