
//function Export(str) {
//    var stringhref = "/Home/CorruptionPath?";

//    stringhref += str;
//    //window.open(stringhref, '_blank');
//    window.location = stringhref;
//    //window.location = "/Home/Export/";
//}

function Export(str) {
    $.ajax({
        url: "/Home/CorruptionPath/" + str,
        type: "GET",
        contentType: "application/json;charset=UTF-8",
        data: JSON.stringify(),
        dataType: "html",
        success: function (result) {
            $('#ServicesModalContent').html(result);
            $('#ServicesModal').modal('show');
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }

    })
}

function GetLastName() {

    var isValid = true;


    if ($('#SearchName').val() == "") {
        $('#SearchName').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#SearchName').css('border-color', 'lightgrey');
    }


    if (isValid == false) {
        return false;
    }

    var data = {
        //'ID': ID,
        'str': $('#SearchName').val()

    };

    $("#search").html("");

    var x = document.getElementById("loadImg");
    x.style.display = "block";

    $.ajax({
        url: "/Home/GetLastName",
        type: "POST",
        contentType: "application/json;charset=UTF-8",
        data: JSON.stringify(data),
        dataType: "html",
        success: function (data) {
            x.style.display = "none";
            $('#search').hide();
            $('#search').html(data).animate({ opacity: 'show' }, "slow");
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });

}

function GetLastName1() {

    var isValid = true;

    if ($('#SearchName').val() == "") {
        $('#SearchName').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#SearchName').css('border-color', 'lightgrey');
    }



    if (isValid == false) {
        return false;
    }


    var data = {

        'str': $('#SearchName').val(),

    };
    $("#search").html("");

    var x = document.getElementById("loadImg");
    x.style.display = "block";

    $.ajax({

        url: "/Home/GetLastName1",
        type: "POST",
        contentType: "application/json;charset=UTF-8",
        data: JSON.stringify(data),
        dataType: "html",
        success: function (data) {
            //$('#search').replaceWith(data);
            x.style.display = "none";
            $('#search').hide();
            $('#search').html(data).animate({ opacity: 'show' }, "slow");

        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}