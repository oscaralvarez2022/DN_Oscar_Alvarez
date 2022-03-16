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

    var t = document.getElementById("sampleTableBody");
    var currentHTML = t.innerHTML;
    currentHTML += "<tr><td>" + btnName + "</td><td>" + moment(new Date()).format("DD-MM-YYYY h:mm:ss a") + "</td></tr>";
    t.innerHTML = currentHTML;


    //alert("Click on: " + buttonName);

    //debugger;
}

for (var i = 0; i < buttons.length; i++) {
    buttons[i].addEventListener("click", onButtonClick);
}

//debugger;


(function () {

    document.getElementById("button1").addEventListener("click", function () {
        const options = {
            style: {
                main: {
                    background: "pink",
                    color: "black",
                },
            },
            settings: {
                duration: 1000,
            },
        };

        iqwerty.toast.toast('Hello!',options);
    });

    var bv = new Bideo();
    bv.init({
        // Video element
        videoEl: document.querySelector('#background_video'),

        // Container element
        container: document.querySelector('body'),

        // Resize
        resize: true,

        // autoplay: false,

        

        // Array of objects containing the src and type
        // of different video formats to add
        src: [
            {
                src: '/lib/bideo/night.mp4',
                type: 'video/mp4'
            }
        ],

        // What to do once video loads (initial frame)
        onLoad: function () {
            document.querySelector('#video_cover').style.display = 'none';
        }
    });
}());


