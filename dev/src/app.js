import $ from "jquery";

$("#btnCollapse").click(function() {
    $("#menuCollapse").slideToggle('medium', function() {
        if ($(this).is(':visible'))
            $(this).css('display','flex');
    });
    console.log("click");
});