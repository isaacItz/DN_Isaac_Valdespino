var element = document.getElementById("example");
var textElement = "hi I'm a string bro";
var aNumber = 123;
var complexObject = {
    name: "isaac",
    lastName: "valdespino",
    age : 32,
}

var ul = "<ul>";
var text1 = "hi";
var text2 = 'hi';

for (let i = 0; i < textElement.length; i++) {
    ul += ("<li>" + textElement[i] + "</li>");
}
ul += "</ul>";

data = "12332";

element.innerHTML = typeof (parseInt(data));