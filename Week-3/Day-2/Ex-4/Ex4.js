var Car = /** @class */ (function () {
    function Car(make, model, year) {
        this.make = make;
        this.model = model;
        this.year = year;
    }
    Car.prototype.displayCarInfo = function () {
        console.warn("".concat(this.make, " ").concat(this.model, " (").concat(this.year, ")"));
    };
    return Car;
}());
var C = new Car("Toyoto", "Camry", 2021);
C.displayCarInfo();
