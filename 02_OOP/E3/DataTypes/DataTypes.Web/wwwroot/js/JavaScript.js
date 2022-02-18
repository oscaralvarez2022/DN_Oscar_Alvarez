let Name = ["Moy", "Oscar", "Daniel", "Jorge", "Xitlali", "Karla", "Carlos", "Juan", "Luna", "Lady"]
let dateRegister = ["2021-01-01", "2021-01-02", "2021-01-03", "2021-01-04", "2021-01-05", "2021-01-06", "2021-01-07", "2021-01-08", "2021-01-09", "2021-01-10"];

function printList() {
    var ul = "<ul>";

    for (var i = 0; i < Name.length; i++) {
        ul += ("<li>" + Name[i] + " " + dateRegister[i] + "</li>");
        //alert("ss");
    }

    ul += "</ul>";

    alert(ul);
    var element = document.getElementById("list");
    element.innerHTML = ul;
}
