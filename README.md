# _Word Counter_

#### _This in-console app will tells you how many times a specific word appears in a sentence. 2/15/2019_

#### _By **Dave Sarbora**_

## _Description_
_This program asks for a sentence from a user, and then a word to match within the sentence. It finds the number of matches within the word by splitting the word into an array of strings, delineated by spaces or punctuation markings. It then compares each word in the array to the search term and increments a counter each time it finds a match. Finally, the value of the counter is printed to the console. 

## _Specifications_

| Sentence Input | Word To Search | Expected Output        |
|----------------|----------------|------------------------|
|Cat             |Dog             |Match not found.        |
|Dogs and dogs!--|Dog             |Match not found.        |
|Dog             |Dog             |Found 1 match for dog.  |
|Dog and dog!    |Dog             |Found 2 matches for dog.|

## _Setup/Installation Requirements_
Download .NET Core 1.1.4 SDK and .NET Core Runtime 1.1.2 and install.
Download Mono and install.

* _Clone the project from [https://github.com/dsarbora/WordCounter](https://github.com/dsarbora/WordCounter)
* _Navigate in the command line to WordCounter.Solution/WordCounter.Test/
* _Use the command $dotnet restore to import the packages used for this project._
* _To run the tests, use the command $dotnet test
* _To run the program, navigate in the command line to WordCounter.Solution/WordCounter_
* _To run in console, compile the project using the command $mcs Program.cs Models/RepeatCounter.cs. Run the file with the command $mono Program.exe_
* _To run in your browser, use the command $dotnet build, and then $dotnet run._
* _Navigate to http://localhost:5000/ in your web browser to get started.


## _Known Bugs_
_The search term must be a single word without any punctuation markings to return any matches due to the way the program splits the original string._

## _Support and Contact Details_
_Contact me at [dsarbora@gmail.com](dsarbora@gmail.com)_

## _Technologies Used_
* _C#_
* _MS Visual Studio Code_
* _Microsoft.NET.Sdk_
* _Microsoft.NET.Test.Sdk_
* _MSTest.TestAdaper_
* _MSTest.TestFramework_

### _License_

*MIT*

Copyright (c) 2019 **_Dave Sarbora_**