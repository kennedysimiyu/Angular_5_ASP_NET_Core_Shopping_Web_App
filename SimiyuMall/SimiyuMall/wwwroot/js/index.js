// declared an initialized variables
var x = 0;

var s = "";

// log information on console when the script is loaded
console.log("Hello Customer");

// variable storing a functionality for hidding the contactForm
var contactForm = document.getElementById("contactForm");
    contactForm.hidden = true;

    // variable with a functionality to show on the logs that the buy item button has been clicked.
    var button = document.getElementById("buyButton");

    button.addEventListener("click", function () {
    console.log("Buying Item")
    });

// product info functionalities.
var productInfo = document.getElementsByClassName(items - props);
var listItems = productInfo.item[0].children;