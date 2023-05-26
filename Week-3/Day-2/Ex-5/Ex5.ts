type StringOrArray = string | any[];

function getLength(input: StringOrArray): number {
  return Array.isArray(input) ? input.length : input.length;
}


const str = "Hello, TypeScript!";
const arr = [1, 2, 3, 4, 5];

console.log(getLength(str)); 
console.log(getLength(arr)); 
