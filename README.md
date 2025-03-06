Old Mobile Phone Keypad Input Text Converter With C# Challenge

Summary
This project provides a method to convert text from older mobile phone keypad inputs using C#.

Features
Handles special characters *(backspace) and # (end of input).

Supports all numeric keypad inputs (0-9) with associated characters.
It Contains unit tests to confirm the feature works as intended.

Installation
Clone the repository:
git clone https://github.com/Parimalm89/IornSoft_CodeChallange.git
Copy

Open the solution in Visual Studio.

Build the project to restore dependencies.

Usage
Start the app.

The test cases are run automatically and the results are printed using the method.
Example
string result1 = MobilePhone.OldPhonePad("222 2 22#");// O/P = CAB
Console.WriteLine("222 2 22# => " + result1);

Copy
Unit Tests
This project contains a set of unit tests for the OldPhonePad method which allow users to verify the different functionalities. The unit tests can check repeated key presses, backspace, and other characters.
