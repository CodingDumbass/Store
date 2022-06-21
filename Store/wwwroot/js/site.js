$('#btn-1,#btn-2').click(function () {
    var btn = $(this).data("showbutton");
    showButtonText(btn);
});
function showButtonText(btn) {

    // reset
    $('.text').hide();
    $('[data-button]').hide();
    $('[data-showbutton]').removeClass('clicked');

    // only show the selected
    if (btn == 2) {
        $("#login")[0].reset();
    }
    else {
        $("#register")[0].reset();
    }
    $('[data-showbutton=' + btn + ']').addClass('clicked');
    $('[data-button=' + btn + ']').show();
}
function clearData() {
    $("#login")[0].reset();
    $("#register")[0].reset();
}
