import $ from "jquery";

$("#btnCollapse").click(function() {
    $("#menuCollapse").slideToggle('medium', function() {
        if ($(this).is(':visible'))
            $(this).css('display','flex');
    });
    console.log("click");
});

$("#btnRight").click(function() {
    $(".listing__images__img--front").css("display", "none");
    $(".listing__images__img--back").css("display", "inline-block");
    $("#btnRight").addClass("disabled");
    $("#btnLeft").removeClass("disabled");
});
$("#btnLeft").click(function() {
    $(".listing__images__img--back").css("display", "none");
    $(".listing__images__img--front").css("display", "inline-block");
    $("#btnLeft").addClass("disabled");
    $("#btnRight").removeClass("disabled");
});