let txtInput = $("#txtInput");
let btnEvaluate = $("#btnEvaluate");

btnEvaluate.click(function () {
    $.ajax({
        type: "GET",
        url: "Home/IsSquareNumber/" + txtInput.value,
        success: function (response) {
            console.log(response);
        },
        error: function (response) {
            console.log(response);
        }
    });
});
