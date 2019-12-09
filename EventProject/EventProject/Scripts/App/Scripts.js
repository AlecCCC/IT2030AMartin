function searchFailed() {
    $("#searchresults").html("Sorry there was a problem with the search");
}


$(function () {
    $(".RemoveLink").click(function () {
        alert("Item removed, Click ok to proceed")
        var id = $(this).attr("data-id");

        $.post("/ShoppingCart/RemoveFromCart", { "id": id }, function (data) {

            $("#update-message").text(data.Message);
            $("#item-count" + data.DeleteId).text(data.ItemCount);


            if (data.ItemCount < 1) {
                $("#record-" + data.DelteId).fadeOut();
            }
        });
    })
});
