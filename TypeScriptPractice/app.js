/*
class Greeting {
    greet(): void {
        console.log("Hello World from TypeScript!!!")
    }
}
var obj = new Greeting();
obj.greet();

var name: string = "John";
var score1: number = 50;
var score2: number = 42.50
var sum = score1 + score2

console.log("\n name: " + name)
console.log("first score: " + score1)
console.log("second score: " + score2)
console.log("sum of the scores: " + sum)


var str = '1'
var str2: number = <any>str   //str is now of type number
console.log(typeof (str2))


var global_num = 12          //global variable
class Numbers {
    num_val = 13;             //class variable
    static sval = 10;         //static field

    storeNum(): void {
        var local_num = 14;    //local variable
    }
}
console.log("Global num: " + global_num)
console.log(Numbers.sval)   //static variable
var obj = new Numbers();
console.log("Global num: " + obj.num_val)


var num: number = 2
if (num > 0) {
    console.log(num + " is positive")
} else if (num < 0) {
    console.log(num + " is negative")
} else {
    console.log(num + " is neither positive nor negative")
}



var grade: string = "A";
switch (grade) {
    case "A": {
        console.log("Excellent");
        break;
    }
    case "B": {
        console.log("Good");
        break;
    }
    case "C": {
        console.log("Fair");
        break;
    }
    case "D": {
        console.log("Poor");
        break;
    }
    default: {
        console.log("Invalid choice");
        break;
    }
}

var num: number = 15;
var i: number;
var factorial = 1;

for (i = num; i >= 1; i--) {
    factorial *= i;
}
console.log(factorial)



function disp_details(id: number, name: string, mail_id?: string) {
    console.log("ID:", id);
    console.log("Name", name);

    if (mail_id != undefined)
        console.log("Email Id", mail_id);
}

disp_details(123, "John");
disp_details(111, "mary", "mary@xyz.com");


function addNumbers(...nums: number[]) {
    var i;
    var sum: number = 0;

    for (i = 0; i < nums.length; i++) {
        sum = sum + nums[i];
    }
    console.log("sum of the numbers", sum)
}
addNumbers(1, 2, 3)
addNumbers(10, 10, 10, 10, 10)



function toCelcius(degreeF: number) {
    return (5 / 9) * (degreeF - 32);
}

console.log("212 degree Farhennite = " + toCelcius(212));



function calculate_discount(price: number, rate: number = 0.50) {
    var discount = price * rate;
    console.log("Discount Amount: ", discount);
}
calculate_discount(1000)
calculate_discount(1000, 0.30)

var msg = function () {
    return "hello world";
}
console.log(msg())

var res = function (a: number, b: number) { //function expression
    return a * b;
};

console.log(res(12, 2))

function result (a: number, b: number) { //Function Declaration
    return a * b;
};



(function () {
    var x = "Hello!!";
    console.log(x)
})()


var foo = (x: number) => 10 + x
console.log(foo(100))



var foo = (x: number) => {
    x = 10 + x
    console.log(x)
}
foo(100)

var func = (x) => {
    if (typeof x == "number") {
        console.log(x + " is numeric")
    } else if (typeof x == "string") {
        console.log(x + " is a string")
    }
}

func(12)
func("Tom")



function disp(s1: string): void;
function disp(n1: number, s1: string): void;

function disp(x: any, y?: any): void {
    console.log(x);
    console.log(y);
}

disp("abc")
disp(1, "xyz");

console.log("TypeScript Number Properties: ");
console.log("Maximum value that a number variable can hold: " + Number.MAX_VALUE);
console.log("The least value that a number variable can hold: " + Number.MIN_VALUE);
console.log("Value of Negative Infinity: " + Number.NEGATIVE_INFINITY);
console.log("Value of Negative Infinity:" + Number.POSITIVE_INFINITY);



var alphas: string[];
alphas = ["1", "2", "3", "4"]
console.log(alphas[0]);
console.log(alphas[1]);



function isBigEnough(element, index, array) {
    return (element >= 10);
}

var passed = [12, 5, 8, 130, 44].every(isBigEnough);
console.log("Test Value : " + passed);
var arr = [12, 5, 8, 130, 44];

var filteredArr = [12, 5, 8, 130, 44].filter(isBigEnough);
console.log("Test Value : " + filteredArr);


var numbers = new Array(1, 4, 9);
var length = numbers.push(10);
console.log("new numbers is : " + numbers);
length = numbers.push(20);
console.log("new numbers is : " + numbers);

numbers.pop();
console.log("new numbers is : " + numbers);

numbers.pop();
console.log("new numbers is : " + numbers);



interface IPerson {
    firstName: string,
    lastName: string,
    sayHi: () => string
}

var customer: IPerson = {
    firstName: "Tom",
    lastName: "Hanks",
    sayHi: (): string => { return "Hi there" }
}

console.log("Customer Object ")
console.log(customer.firstName)
console.log(customer.lastName)
console.log(customer.sayHi())

var employee: IPerson = {
    firstName: "Jim",
    lastName: "Blakes",
    sayHi: (): string => { return "Hello!!!" }
}

console.log("Employee  Object ")
console.log(employee.firstName);
console.log(employee.lastName);


class Car {
    //field
    engine: string;

    //constructor
    constructor(engine: string) {
        this.engine = engine
    }

    //function
    disp(): void {
        console.log("Function displays Engine is  :   " + this.engine)
    }
}

//create an object
var obj = new Car("XXSY1")

obj.engine = "Changed Value";

//access the field
console.log("Reading attribute value Engine as :  " + obj.engine)

//access the function
obj.disp()

class Shape {
    Area: number

    constructor(a: number) {
        this.Area = a
    }
}

class Circle extends Shape {
    disp(): void {
        console.log("Area of the circle:  " + this.Area)
    }
}

var obj = new Circle(223);
obj.disp()

*/
var invokeperson = function (obj) {
    console.log("first name :" + obj.firstname);
    console.log("last name :" + obj.lastname);
};
invokeperson({ firstname: "Sachin", lastname: "Tendulkar" });
//# sourceMappingURL=app.js.map