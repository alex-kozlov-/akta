(function () {

    var $sidebarAndWrapper = $('#sidebar, #wrapper');

    $('#toggleSidebar').on('click', function () {

        $sidebarAndWrapper.toggleClass('hide-sidebar');

        if ($sidebarAndWrapper.hasClass('hide-sidebar')) {
            $(this).text("Show Toggle");
        } else {
            $(this).text("Hide Toggle");
        }
    })
})()