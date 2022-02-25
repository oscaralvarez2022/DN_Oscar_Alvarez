function onKeyUp(event,action) {
    var keycode = event.keyCode;
    if (keycode == '13') {
        document.getElementById("button"+action).click();
    }
}

document.addEventListener("DOMContentLoaded", function () {

    if (document.getElementById("buttonOUT")) {
        var btnOUT = document.getElementById("buttonOUT");
        btnOUT.addEventListener("click", function () {

            var myModal = new bootstrap.Modal(document.getElementById("myModalOUT"));
            var myModalOUT = document.getElementById("myModalOUT");

            myModalOUT.querySelector(".modal-body").innerHTML = getDataAttendance("OUT");
            myModal.show();
            setTimeout(function () { myModal.hide(); }, 3000);
        });
    }

    if (document.getElementById("buttonIN")) {
        var btnIN = document.getElementById("buttonIN");
        btnIN.addEventListener("click", function () {
            var myModal = new bootstrap.Modal(document.getElementById("myModalIN"));
            var myModalIN = document.getElementById("myModalIN");

            myModalIN.querySelector(".modal-body").innerHTML = getDataAttendance("IN");
            myModal.show();

            setTimeout(function () { myModal.hide(); }, 3000);
        });
    }
});

function getDataAttendance(action) {
    var fullToday = new Date();
    var todayDate = fullToday.getDate() + '-' + (fullToday.getMonth() + 1) + '-' + fullToday.getFullYear();
    var todayTime = fullToday.getHours() + ':' + fullToday.getMinutes() + ':' + fullToday.getSeconds();
    var fullDate = todayDate + ' ' + todayTime;

    var memberId = document.getElementById('memberId').value;

   return  "<p>" + action + " register by " + memberId + " " + fullDate + " </p>";
}


