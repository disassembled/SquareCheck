let txtInput = $("#txtInput");
let btnEvaluate = $("#btnEvaluate");
let lblOutput = $("#lblResult");

btnEvaluate.click(function () {
    $.ajax({
        type: "GET",
        url: "Home/IsSquareNumber/" + txtInput.val(),
        success: function (response) {
            btnEvaluate.prop('disabled', true);
            lblOutput.text(response.message);
            lblOutput.css("color", response.isSquare ? "#00FF00" : "#FF0000");
            lblOutput.show();
            setTimeout(() => lblOutput.fadeOut(500), 1500);
            setTimeout(() => btnEvaluate.prop('disabled', false), 2000);
        },
        error: function (response) {
            alert(response);
        }
    });
});
