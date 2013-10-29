$("a.employee-link").click(function () {
    var li = $(this).parents("li");
    var detail = $(".employee-details", li);
    if (detail.is(":visible"))
        detail.slideUp();
    else
        detail.slideDown();

    return false;
});