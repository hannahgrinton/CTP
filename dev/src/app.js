import $ from "jquery";
//navigation collapse functionality
$("#btnCollapse").click(function() {
    $("#menuCollapse").slideToggle('medium', function() {
        if ($(this).is(':visible'))
            $(this).css('display','flex');
    });
    console.log("click");
});
//image navigation
$("#btnRight").click(function() {
    $(".listing__images__img--front").css("display", "none");
    $(".listing__images__img--back").css("display", "inline-block");
    $("#btnRight").addClass("disabled");
    $("#btnLeft").removeClass("disabled");
});
//image navigation
$("#btnLeft").click(function() {
    $(".listing__images__img--back").css("display", "none");
    $(".listing__images__img--front").css("display", "inline-block");
    $("#btnLeft").addClass("disabled");
    $("#btnRight").removeClass("disabled");
});
//item sorting on the ministry page
$("#ministry-sort").change(function() {
    let list = $("#tblMinistry");
    let listitems = list.children(".table__grid__item");
    if ($(this).val() == "spanish") {
        //sort by spanish
        $( listitems ).each(function( index ) {
            console.log( index + ": " + $(this).find(".grid-item-code").text());
            if (~$(this).find(".grid-item-code").text().indexOf("SPB") || ~$(this).find(".grid-item-code").text().indexOf("SVB-313")) {
                console.log("passed if statement");
                $(list).append(this);
            } else {
                $(this).css("display", "none");
            }
          });
    }
    if ($(this).val() == "title") {
        //sort by title
        $(listitems).css("display", "inline");
        listitems.sort(function(a,b) {
            let compA = $(a).find(".grid-item-title").text().toUpperCase().replace(/\"/g, "");
            let compB = $(b).find(".grid-item-title").text().toUpperCase().replace(/\"/g, "");
            return (compA < compB) ? -1 : (compA > compB) ? 1 : 0;
        });
        $(list).append(listitems);
    }
    if ($(this).val() == "author") {
        $(listitems).css("display", "inline");
        //sort by author
        listitems.sort(function(a,b) {
            let compA = $(a).find(".grid-item-author").text().toUpperCase().replace(/\"/g, "");
            let compB = $(b).find(".grid-item-author").text().toUpperCase().replace(/\"/g, "");
            return (compA < compB) ? -1 : (compA > compB) ? 1 : 0;
        });
        $(list).append(listitems);
    }
    if ($(this).val() == "price") {
        $(listitems).css("display", "inline");
        //sort by price
        listitems.sort(function(a,b) {
            let compA = parseFloat($(a).find(".grid-item-price").text().replace(/\$/g, ""));
            let compB = parseFloat($(b).find(".grid-item-price").text().replace(/\$/g, ""));
            return compA - compB;
        });
        $(list).append(listitems);
    }
});
//item sorting on the expositions page
$("#exp-sort").change(function() {
    let list = $("#tblExp");
    let listitems = list.children(".table__grid__item");
    if ($(this).val() == "title") {
        //sort by title
        listitems.sort(function(a,b) {
            let compA = $(a).find(".grid-item-title").text().toUpperCase().replace(/\"/g, "");
            let compB = $(b).find(".grid-item-title").text().toUpperCase().replace(/\"/g, "");
            return (compA < compB) ? -1 : (compA > compB) ? 1 : 0;
        });
        $(list).append(listitems);
    }
    if ($(this).val() == "author") {
        //sort by author
        listitems.sort(function(a,b) {
            let compA = $(a).find(".grid-item-author").text().toUpperCase().replace(/\"/g, "");
            let compB = $(b).find(".grid-item-author").text().toUpperCase().replace(/\"/g, "");
            return (compA < compB) ? -1 : (compA > compB) ? 1 : 0;
        });
        $(list).append(listitems);
    }
    if ($(this).val() == "price") {
        //sort by price
        listitems.sort(function(a,b) {
            let compA = parseFloat($(a).find(".grid-item-price").text().replace(/\$/g, ""));
            let compB = parseFloat($(b).find(".grid-item-price").text().replace(/\$/g, ""));
            return compA - compB;
        });
        $(list).append(listitems);
    }
    if ($(this).val() == "nonumbers") {
        //sort by title ignoring "1st"/"2nd" in string
        listitems.sort(function(a,b) {
            let compA = $(a).find(".grid-item-title").text().toUpperCase().replace("1ST ", "").replace("2ND ", "").replace("-", "").replace(" ", "");
            let compB = $(b).find(".grid-item-title").text().toUpperCase().replace("1ST ", "").replace("2ND ", "").replace("-", "").replace(" ", "");
            return (compA < compB) ? -1 : (compA > compB) ? 1 : 0;
        });
        $(list).append(listitems);
    }
    if ($(this).val() == "biblically") {
        //sort biblically
        listitems.sort(function(a,b) {
            let compA = $(a).find(".grid-item-code").text().replace("RB-", "").replace("SVB-", "");
            let compB = $(b).find(".grid-item-code").text().replace("RB-", "").replace("SVB-", "");
            return (compA < compB) ? -1 : (compA > compB) ? 1 : 0;
        });
        $(list).append(listitems);
    }
});
//item sorting on the booklet page
$("#booklet-sort").change(function() {
    let list = $("#tblBooklets");
    let listitems = list.children(".table__grid__item");
    if ($(this).val() == "spanish") {
        //sort by spanish
        $(listitems).css("display", "inline");
        $( listitems ).each(function( index ) {
            console.log( index + ": " + $(this).find(".grid-item-code").text());
            if (~$(this).find(".grid-item-code").text().indexOf("SPB")) {
                console.log("passed if statement");
                $(list).append(this);
            } else {
                $(this).css("display", "none");
            }
          });
    }
    if ($(this).val() == "french") {
        //sort by french
        $(listitems).css("display", "inline");
        $( listitems ).each(function( index ) {
            console.log( index + ": " + $(this).find(".grid-item-code").text());
            if (~$(this).find(".grid-item-code").text().indexOf("FB")) {
                console.log("passed if statement");
                $(list).append(this);
            } else {
                $(this).css("display", "none");
            }
          });
    }
    if ($(this).val() == "title") {
        //sort by title
        $(listitems).css("display", "inline");
        listitems.sort(function(a,b) {
            let compA = $(a).find(".grid-item-title").text().toUpperCase().replace(/\"/g, "").replace("Ê", "E");
            let compB = $(b).find(".grid-item-title").text().toUpperCase().replace(/\"/g, "").replace("Ê", "E");
            return (compA < compB) ? -1 : (compA > compB) ? 1 : 0;
        });
        $(list).append(listitems);
    }
    if ($(this).val() == "author") {
        //sort by author
        $(listitems).css("display", "inline");
        listitems.sort(function(a,b) {
            let compA = $(a).find(".grid-item-author").text().toUpperCase().replace(/\"/g, "");
            let compB = $(b).find(".grid-item-author").text().toUpperCase().replace(/\"/g, "");
            return (compA < compB) ? -1 : (compA > compB) ? 1 : 0;
        });
        $(list).append(listitems);
    }
    if ($(this).val() == "price") {
        //sort by price
        $(listitems).css("display", "inline");
        listitems.sort(function(a,b) {
            let compA = parseFloat($(a).find(".grid-item-price").text().replace(/\$/g, ""));
            let compB = parseFloat($(b).find(".grid-item-price").text().replace(/\$/g, ""));
            return compA - compB;
        });
        $(list).append(listitems);
    }
});
//item sorting on the ebook page
$("#ebook-sort").change(function() {
    let list = $("#tblEbook");
    let listitems = list.children(".table__grid__item");
    if ($(this).val() == "title") {
        //sort by title
        listitems.sort(function(a,b) {
            let compA = $(a).find(".grid-item-title").text().toUpperCase().replace(/\"/g, "").replace("1ST ", "").replace("2ND ", "").replace("3RD ", "").replace("-", "");
            let compB = $(b).find(".grid-item-title").text().toUpperCase().replace(/\"/g, "").replace("1ST ", "").replace("2ND ", "").replace("3RD ", "").replace("-", "");
            return (compA < compB) ? -1 : (compA > compB) ? 1 : 0;
        });
        $(list).append(listitems);
    }
    if ($(this).val() == "author") {
        //sort by author
        listitems.sort(function(a,b) {
            let compA = $(a).find(".grid-item-author").text().toUpperCase().replace(/\"/g, "");
            let compB = $(b).find(".grid-item-author").text().toUpperCase().replace(/\"/g, "");
            return (compA < compB) ? -1 : (compA > compB) ? 1 : 0;
        });
        $(list).append(listitems);
    }
});
//image file name update
$("#imgFile").change(function() {
    console.log($(this).val());
    var filename = $(this).val().split("\\").pop();
    $("#message").text(filename);
});
$("#frontcover").change(function() {
    console.log($(this).val());
    var filename = $(this).val().split("\\").pop();
    $("#message").text(filename);
});
$("#backcover").change(function() {
    console.log($(this).val());
    var filename = $(this).val().split("\\").pop();
    $("#message1").text(filename);
});
//epub file name update
$("#epub").change(function() {
    console.log($(this).val());
    var filename = $(this).val().split("\\").pop();
    $("#epub-message").text(filename);
});
//mobi file name update
$("#mobi").change(function() {
    console.log($(this).val());
    var filename = $(this).val().split("\\").pop();
    $("#mobi-message").text(filename);
});