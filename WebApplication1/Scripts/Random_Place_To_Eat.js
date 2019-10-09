$(document).ready(function () {
    $('#PlaceToEat').text("fuck you levi");
    $('#btn').click(function () {

        $.ajax({
            type: "Post",
            url: '/Home/DecideLunchPlace',
            dataType: "json",
            success: function (data) {
                //alert(data);
                $('#PlaceToEat').text(data);
            },
            error: function () {
                alert("Something wrong");
            } 
        });
    });
});