function ValidaCaracteres(valor) {
    var parsed = true;
    var validchars = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ@!.0123456789";

    for (var i = 0; i < valor.length; i++) {
        var letter = valor.charAt(i).toLowerCase();
        if (validchars.indexOf(letter) != -1)
            continue;
        parsed = false;
        break;
    }
    return parsed;
}

function alertifyMessageLogin(text) {
    try {
        swal({ title: "Bienvenido.", text: text, type: "success", allowOutsideClick: false })
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
