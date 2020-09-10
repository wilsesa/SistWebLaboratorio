//function templateRow() {
//    var template = "<tr>";
//    template += ("<td>" + "123" + "</td>");
//    template += ("<td>" + "123" + "</td>");
//    template += ("<td>" + "123" + "</td>");
//    template += ("<td>" + "123" + "</td>");
//    template += ("<td>" + "123" + "</td>");
//    template += ("<td>" + "123" + "</td>");
//    template += "</tr>"
//    return template;
//}

//function addRowToDataTable() {
//    var template = templateRow();
//    for (var i = 0; i < 10; i++) {
//        $("#tbl_body-table").append(template);
//    }
//}

//addRowToDataTable();



function addRowDT(data) {
    var tabla = $("#tbl_pacientes").DataTable();
    for (var i = 0; i < data.length; i++) {
        tabla.fnAddData([
            data[i].IdPaciente,
            data[i].Nombres,
            (data[i].ApPaterno + " " + data[i].ApMaterno),
            ((data[i].Sexo == 'M')? "Masculino": "Femenino"),
            data[i].Edad,
            data[i].Direccion,
            ((data[i].Estado == true)? "Activo": "Inactivo"),
        ]);
    }
}

//Llamamos la funcion mediante ajax
function sendDataAjax() {
    $.ajax({
        type: "POST",
        url: "GestionarPaciente.aspx/ListarPacientes",
        data: {},
        contentType: 'application/json; charset=utf-8',
        error: function (xhr, ajaxOptions, thrownError) {
            console.log(xhr.status + " \n" + xhr.responseText, "\n" + thrownError);
        },
        success: function (data) {
            //console.log(data);
            addRowDT(data.d);
        }
    });
}

//Llamando a la funcion de ajax al cargar el documento
sendDataAjax();