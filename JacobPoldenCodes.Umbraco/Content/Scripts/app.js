$(".menu-toggle").click( () => {
    $("#wrapper").toggleClass("toggled");
});

$("#page-content-wrapper").click(() => {
    if (!$("#wrapper").hasClass("toggled")) {
        $("#wrapper").toggleClass("toggled");
    }
});