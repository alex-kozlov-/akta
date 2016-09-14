(function () {

    var $sidebarAndWrapper = $('#sidebar, #wrapper');

    $('#toggleSidebar').on('click', function () {

        $sidebarAndWrapper.toggleClass('hide-sidebar');
        $toggleIcon = $('#toggleSidebar i.fa');

        if ($sidebarAndWrapper.hasClass('hide-sidebar')) {
            $toggleIcon.removeClass('fa-angle-left');
            $toggleIcon.addClass('fa-angle-right');
        } else {
            $toggleIcon.removeClass('fa-angle-right');
            $toggleIcon.addClass('fa-angle-left');
        }
    })
})()