
interface Person{
    firstname:string,
    lastname:string,
    age:number
}
function introduce(person:Person):void{
    console.warn((`${person.firstname} ${person.lastname} is ${person.age} years old.`));  
}

const person:Person={
    firstname: "Priyanka",
    lastname : "Parmar",
    age :23
}
introduce(person);