﻿function ProcessResponse(appt) {
    $("#successClientName").text(appt.ClientName);
    $("#successDate").text(ProcessDate(appt.Date));
    switchViews();
}

function ProcessDate(dateString) {
    return new Date(parseInt(dateString.substr(6,
        dateString.length - 8))).toDateString();
}

function switchViews() {
    var hidden = $(".hidden");
    var visible = $(".visible");
    hidden.removeClass("hidden").addClass("visible");
    visible.removeClass("visible").addClass("hidden");
}

$(document).ready(function () {
    $("#backButton").click(function (e) {
        switchViews();
    });
});
