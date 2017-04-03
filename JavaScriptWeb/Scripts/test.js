module('Calculator Test Suite',
{
    setup: function() { initialize(); }
});



test("A Hello World Test", 1, function () {
    var greeting = 'Hello World';
    equal(greeting, "Hello World", "Expect greeting of Hello World");
});

test("Array Test",1,function() {
    var pizzaParts = new Array();
    pizzaParts[0] = 'pepperoni';
    pizzaParts[1] = 'onion';
    pizzaParts[2] = 'bacon';

    var pizzaPartsCondensed = new Array('pepperoni', 'onion', 'bacon');
    var pizzPartsLiteral = ['pepperoni', 'onion', 'bacon'];
    var pizzaMeats = new Array('ham', 'bacon', 'sausage');
    var pizzaVegs = ['pepper', 'onion'];
    var pizzMeatsVeg = pizzaMeats.concat(pizzaVegs);

    equal(pizzaParts.length, pizzPartsLiteral.length, "Expected length = 3");
    /* array methods:
     - concat
     - indexOf
     - join
     - lastIndexOf
     - pop* - removes and retrun the the last item of an array
     - push* - adda a new item to the end of an Array and return the new length
     - reverse
     - *shift()  removes and return the first item in the array if no items are in the array returns undefined.

     - slice(start, end) - returns a new array that represents part of an existing array
       start index to include (zero based),  end index not to include.
     - sort
     - splice(startindex, numitemsToRemove, strItemstoAdd) - Adds and remove items from an array and returns removed items. The original array is modified.
     - *unshift - Adds a new item to the beginning of an Array and return the new length
     - valueOf (all objects has this mehod) - returns the primitive values of an Array as a comma delimited string.


    */
});


test("Btn5 Click Test",function() {
    expect(1);
    var btn = document.getElementById("btn5");
    QUnit.triggerEvent(btn, "click");
    var result = txtInput.value;
    var expected = '5';
    equal(result, expected, 'Expected value: ', + expected + ' Actual value: ' + result);
});
