$(document).on("click", ".add_tofavorites", function (e) {
    var id = $(this).attr("data-id");
    var Div = document.createElement("div");
    Div.className = "alert alert-primary";
   
    $.ajax({
        url: "/Ajax/AddToFavorites?id=" + id,
        method:"Post",
        success: function (res) {
            if (res.status === 200) {
                Div.innerHTML = '"'+res.message+'"';
                $(".addCard").append(Div);
            }
        }
    });
});