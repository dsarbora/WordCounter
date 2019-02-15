# _Word Counter_

#### _This in-console app will tells you how many times a specific word appears in a sentence. 2/15/2019_

#### _By **Dave Sarbora**_

## _Description_
_This program finds matches in words by looping through a character array, comparing each letter to the first letter of a second array made from word we are searching for. A " " is added to the beginning and end of each array so that only complete words will be matched, but it will also match certain acceptable characters such as punctuation marks that may surround a word.

## _Specifications_

| Sentence Input | Word To Search | Expected Output        |
|----------------|----------------|------------------------|
|Cat             |Dog             |Match not found.        |
|Dogs and dogs!--|Dog             |Match not found.        |
|Dog             |Dog             |Found 1 match for dog.  |
|Dog and dog!    |Dog             |Found 2 matches for dog.|

## _Setup/Installation Requirements_
* _Clone the project from [https://github.com/dsarbora/WordCounter](https://github.com/dsarbora/WordCounter)
* _Navigate to WordCounter.Solution/WordCounter/ in the command line and run the file Program.exe_

## _Known Bugs_
_As of right now the program will not count a word if it begins with one of the "AcceptableCharacters."_

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