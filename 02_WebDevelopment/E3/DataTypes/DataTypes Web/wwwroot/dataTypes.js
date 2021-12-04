var element = document.getElementById("example");       
var data = [{
    name: "isaac",
    age : new Date(),
}, {
        name: "antonio",
        age: new Date(),
    }, {
        name: "robert",
        age: new Date(),
    }, {
        name: "pedro",
        age: new Date(),
    }, {
        name: "armando",
        age: new Date(),
    }, {
        name: "isaias",
        age: new Date(),
    }, {
        name: "jaun",
        age: new Date(),
    }, {
        name: "juan",
        age: new Date(),
    }, {
        name: "joshn",
        age: new Date(),
    }, {
        name: "elon",
        age: new Date(),
    }]

var ul = "<ul>";

for (let i = 0; i < data.length; i++) {
    ul += ("<li> name: " + data[i].name + " Registration date: " + data[i].age + "</li>");
}
ul += "</ul>";

element.innerHTML = ul;