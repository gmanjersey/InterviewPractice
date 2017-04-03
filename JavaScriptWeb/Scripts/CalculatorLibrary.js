var txtInput;

function initialize() {
    txtInput = document.getElementById('txtInput');
    document.getElementById('btn5').addEventListener('click', numberClick, false);
}


function numberClick() {
    txtInput.value = txtInput.value == '0' ? this.innerText : txtInput.value + this.innerText;
}

//dynamic object using factory pattern
function getVehicle(theYear, theMake, theModel) {
    var vehicle = new Object();
    vechicle.year = theYear;
    vechicle.make = theMake;
    vehcicle.model = theModel;

    vehicle.getInfo = function () { };

    return vehicle;
}

//class

//Adding object to local namespace prevent Global namespace pollution:
var myApp = myApp || {};
myApp.vehicleCount = 5;
myApp.vehicles = new Array();
myApp.Car = function () { }
myApp.Truck = function () { }
myApp.repair = {
    description: 'changed spark plugs',
    cost: 100
}


//namespace are singleton  objects so use IIFE to create myApp namespace:
(function() {
    this.myApp = this.myApp || {};
    var ns = this.myApp;

    var vehicleCount = 5;  //private 
    var vechicles = new Array();//private

    ns.Car = function () { } //public
    ns.Truck = function() {}//public

    var repair = { description: "changed spark plugs", cost: 100 };
})();


//Billing Sub Namespace in IIFE:
(function() {

    this.myApp = this.myApp || {};
    var rootNs = this.myApp;
    rootNs.Billing = rootNs.Billing || {};
    var ns = rootNs.Billing;

    var taxRate = 0.05;
    ns.Invoice = function() {}
})();


//Inheritance:
var Vehicle = (function() {

    function Vehicle(year, make, model) {
        this.year = year;
        this.make = make;
        this.model = model;
    }


    Vehicle.prototype.getInfo = function() {
        return this.year + ' ' + this.make + ' ' + this.model;
    };

    Vehicle.prototype.startEngine = function() { return "Vroom"; };

    return Vehicle;
})();


var Car = (function(parent) {
    Car.prototype = new Vehicle();
    Car.prototype.constructor = Car;
    function Car(year, make, model) {
        parent.call(this, year, make, model);
        this.wheelQuantity = 4;
    }

    Car.prototype.getInfo = function() {

        return 'Vehicle Type: Car' + parent.prototype.getInfo.call(this);
    };

    return Car;
})(Vehicle) ;