function introduce(person) {
    console.warn(("".concat(person.firstname, " ").concat(person.lastname, " is ").concat(person.age, " years old.")));
}
var person = {
    firstname: "Priyanka",
    lastname: "Parmar",
    age: 23
};
introduce(person);
