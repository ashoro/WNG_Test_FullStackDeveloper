

$(document).ready(function () {
    $(".startNow").click(function () {
        $(".instr_wrp").slideUp("slow");
        $(".inputs_wrp").slideDown("slow");
    });

    $("#btn_submit").attr('disabled', 'true');
   

    $('#txt_inputNr').on('input', function () {
        if ($("#txt_inputNr").val().length > 0) {
            $("#btn_submit").removeAttr('disabled');
        }
    });

    $("#txt_inputNr").keydown(function (e) {
        if (e.shiftKey || e.ctrlKey || e.altKey) {
            $(".error_msg").html("Enter a positive number Only");
            e.preventDefault();
        } else {
            var key = e.keyCode;
            if (!((key == 8) || (key == 46) || (key >= 35 && key <= 40) || (key >= 48 && key <= 57) || (key >= 96 && key <= 105))) {
                $(".error_msg").fadeIn("slow").text("Enter a positive number Only");
                e.preventDefault();
            } else {
                $(".error_msg").fadeOut("slow");
            }
        }
    });
});