function getLength(input) {
    return Array.isArray(input) ? input.length : input.length;
}
var str = "Hello, TypeScript!";
var arr = [1, 2, 3, 4, 5];
console.log(getLength(str));
console.log(getLength(arr));
