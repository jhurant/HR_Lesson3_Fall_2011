$("a.employee-link").click(function () {
    var li = $(this).parents("li");
    $(".employee-details", li).toggle();
    return false;
});