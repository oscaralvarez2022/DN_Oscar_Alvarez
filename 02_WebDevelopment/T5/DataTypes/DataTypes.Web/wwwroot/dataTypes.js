var buttons = document.getElementsByTagName("button");
//var buttons = document.getElementsByClassName("btn");

function onButtonClick(evt) {
    var b = evt.currentTarget;
    var btnName = b.getAttribute("name");
    var classes = b.classList;
    var isGreen = false;
    for (var i = 0; i < classes.length; i++) {
        var c = classes[i];

        if (c == "greenButton") {
            isGreen = true;
        }
    }

    if (isGreen) {
        b.className = "btn redButton";
    } else {
        b.className = "btn greenButton";
    }

    var t = document.getElementById("sampleTable");
    var currentHTML = t.innerHTML;
    currentHTML += "<tr><td>" + btnName + "</td><td>" + new Date() + "</td></tr>";
    t.innerHTML = currentHTML;


    //alert("Click on: " + buttonName);

    //debugger;
}

for (var i = 0; i < buttons.length; i++) {
    buttons[i].addEventListener("click", onButtonClick);
}

//debugger;


