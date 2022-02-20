function onKeyUp(event,action) {
    var keycode = event.keyCode;
    if (keycode == '13') {
       showModal(action); 
    }
}

document.addEventListener("DOMContentLoaded", function () {
    var myModal = document.getElementById("myModal");

    myModal.addEventListener("show.bs.modal", function (event) {

        // Change modal title
        document.getElementById('modalBody').innerHTML = " </p>";
        //myModal.querySelector(".modal-body").innerHTML = "<p>" + action + " register by " + memberId + " " + fullDate + " </p>";;
    });
});

/*
function showModal(action) {
    var fullToday = new Date();
    var todayDate = fullToday.getDate() + '-' + (fullToday.getMonth() + 1) + '-' + fullToday.getFullYear();
    var todayTime = fullToday.getHours() + ':' + fullToday.getMinutes() + ':' + fullToday.getSeconds();
    var fullDate = todayDate + ' ' + todayTime;

    var memberId = document.getElementById('memberId').value;

    document.getElementById('modalBody').innerHTML = "<p>" + action + " register by " + memberId + " " + fullDate + " </p>";

    var myModal = new bootstrap.Modal(document.getElementById('myModal'));
    myModal.toggle();

    setTimeout('closeModal()', 5000)
   
}

function closeModal() {
    myModal.toggle()
}
*/

