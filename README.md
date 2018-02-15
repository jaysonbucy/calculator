# **Calculator**
This is a simple calculator program in C#

**Definition of problem**  
To create a quick program to display coding ability.

**Solution**  
Using several tutorials I pieced together my version of a simple calculator.

**Explanation**
For a very basic calculator you will need to take two numbers and perform one of the four basic mathimatical operations on them. To start I created a Windows Form with the following:
+  the form itself
+   text box to display inputs and solutions
+  numbers 0-9
+  operators * / + -
+  a decimal
+  and an equals

With those created, I then set the _Name_ field of each button to a readable, individual string and changed the _Text_ field to the descriptive for example _numberOne_ for the 1 button. At this point we need to set methods for each button to handle _Click_ actions. Originally I had a single method for each button click. however, this created a lengthy program to start as there were sixteen buttons with sixteen individual method.  
To remedy this, I created the `button_Click()` method. Inside of that I grabbed the _Text_ field for the button. I then updated a `double` variable called `value`. Finally I had to run two checks on those values. The first rid us of leading zeros and the second ensured you cannot use more than one decimal in a number. That handled all of the available inputs.  
Next I refactored all of the operations into the `operator_Click()` method. Which basically mimiced the `button_Click()` method but for the operators and set a `string` named `operation` to the value passed.  
Finally I needed to solve the actual equation. To do this the `equalsButton_Click()` method was created. This `value` from button click, the `operation` from the opperator click and pulled the final value from the `answerBox` field and set it equal to the `secondNumber` variable. At this point we `switch` on the `operation`, solve for desired result, convert the answer to a string, and display it. Of course we have to handle division by zero since it would throw and error and interupt the program so I send an alert to the user and reset `value` to the first number entered. I chose this method in case the use accidently chose to divide by zero they would not loose the original number and could carry on.  
That solved the basic calculator problem.  
**How to make it better**  
At this point I wanted to add functionality to the program by adding the ability to gather the square root of a number, add a function to handle exponents, handle negative numbers, and add a clear button. Most programmers at this point might also add a clear entry button, and I did. But in the end I realized I never use the clear entry and most people honestly do not know the difference between clear and clear entry so I removed it eventually.  
The exponent function as a simple addition. I was able to include it in the `equalsButton_Click()` method in the switch statement. I used the value and second value with the `Pow` function found in the `Math` libaray included in C#.  
To handle negative numbers, I created a button labled `+/-` and attached it to a `positiveNegative_Click()` method. In the method I check if the number is already negative, if not I add a `-` to the front of the current value. If so, I remove the `-`.  
For the square root, I created a a `squareRoot_Click()` method that takes in the value and uses the `Sqrt` function in the `Math` library to solve. I handled situations where someone would attempt to get the square root of a negative number with another alert to the user informing them of their error and resetting the value to 0. I chose to reset this value as there is only one number in the equation and if they messed it up they messed up the entire equation.
Finally the clear button simply calls `Clear()` on the `answerBox` sets the value to 0.  
**This doesn't look right**  
At this point in testing I noticed that the calculator was no longer clearing the `answerBox` when an operator was chosen. Originally when I had seperate methods per button I was changing the value to 0 after each operation was called. Since I had refactored each into a singular method I needed a new way to clear the box. To do this I created a `bool` variable `operation_pressed` and instansiated it to false. Then I added a check to the `button_Click()` where I had solved the leading zeros. That way if the `operation_pressed` was set to true, it would clear the box. Afterwards I would change it to true after the operator was called and false after a variable button was pushed.  
**Make it even more betterer**  
At this point I wanted to add the ability for the user to stack operations (5+5+5) and also to use the number/operator keys. Stacking the operations ended up being fairly simple and all I need to do was check in the operation method for a value. If there was a value then force the program to perform the equals button click action behind the scenes and then replace the value with that solution then carry on.  
Adding number keys needs a method with a switch and we need to set the form's `KeyPreview` property to true. In the method we are given a `KeyPressEventArgs` which looks at key presses. We will switch on that and are able to find all of the keys we need except for the enter key. To use that like the Windows calculator in so much as it will represent the equals function. To map that we need to have a check outside the switch that converts pressing the enter key into a character and check it versus key press event passed. If they are equal then we preform the equals button click.  
**Final thoughts**  
There are a few naming conventions that I did not follow. I chose to ignore them at this time because they are things like `button_Click` should be `Button_Click`. I have noted it for later. Also, I think I intialized the project incorrectly because there is a file that is apparently not needed but will break the program without it. Again, I believe this is tied to not knowing the IDE very well and just picking up C#, I don't think it would be an issue moving forward. There were a few things I would have liked to done but I feel they were out of scope at this time. I might come back later and add those.
