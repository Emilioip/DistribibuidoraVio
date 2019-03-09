$(function () {
    $('#menuPrincipal a').removeClass('active');
    $('#btnProductos a').addClass('active');




    $('#btn').click(function (e) {
        e.preventDefault();
        var img = $('#img');
        var b64 = btoa(img);
        var unicode = atob(b64);

        console.log(b64);
        console.log(unicode);
    });
});

function encodeImageFileAsURL() {

    var filesSelected = document.getElementById("inputFileToLoad").files;
    if (filesSelected.length > 0) {
        var fileToLoad = filesSelected[0];

        var fileReader = new FileReader();

        fileReader.onload = function (fileLoadedEvent) {
            var srcData = fileLoadedEvent.target.result; // <--- data: base64
            localStorage['img'] = srcData;

            var newImage = document.createElement('img');
            newImage.src = srcData;

            alert(localStorage['img']);
            //document.getElementById("imgTest").innerHTML = newImage.outerHTML;
            //alert("Converted Base64 version is " + document.getElementById("imgTest").innerHTML);
            //$('#imgv').html();
        }
        fileReader.readAsDataURL(fileToLoad);
    }
}