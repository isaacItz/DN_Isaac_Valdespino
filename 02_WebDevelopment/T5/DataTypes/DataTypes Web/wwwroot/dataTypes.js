function onButtonClick(evt) {
    let b = evt.currentTarget;
    let buttonName = b.getAttribute("name");
    let classes = b.classList
    let isGreen = false;
    for (let i = 0; i < classes.length; i++) {
        let color = classes[i];
        if (color == 'greenButton') {
            isGreen = true;
            break;
        }
    }
    if (isGreen) {
        b.className = "buttons redButton";
    } else {
        b.className = "buttons greenButton";
    }
    let table = document.getElementById("sampleTable");
    let tableHtml = table.innerHTML;
    tableHtml += "<tr><td>" + buttonName + "</td><td>" + new Date() + "</td></tr>";
    table.innerHTML = tableHtml;
}
//var button = document.getElementById("button1");
//var button = document.getElementsByTagName("button")[0];
//var button = document.getElementsByName("testButton")[0];
var buttons = document.getElementsByTagName("button");

for (let i = 0; i < buttons.length; i++) {
    buttons[i].addEventListener("click", onButtonClick);
}