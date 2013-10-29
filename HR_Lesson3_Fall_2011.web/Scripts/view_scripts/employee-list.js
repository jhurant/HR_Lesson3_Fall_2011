$("a.employee-link").click(function () {
    var li = $(this).parents("li");
    var detail = $(".employee-details", li);
    if (detail.is(":visible"))
        detail.slideUp();
    else
        detail.slideDown();

    return false;
});

$("a.employee-link-dialog").click(function () {
    $.get(this.href, function (data) {
        $(".modal-body").html(data);
        $(".modal").modal("show");
    });
    return false;
});