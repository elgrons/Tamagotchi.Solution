# _Tamagotchi_

#### By Eliot Gronstal, E Luckie, Jannon Sielaff

#### _A web app where you can create a Tamagotchi object by giving it a name and submitting a form. Made for Week 2 C# Practice at Epicodus Coding School._

## Technologies Used

* _C#_
* _.NET_
* _HTML_
* _MSTest_

## Description

_Make a web app where a user can create a Tamagotchi object by giving it a name and submitting a form._

* _It has properties for the amount of food, attention, and rest it currently has._

* _There is a main page displaying the names of all the Tamagotchi objects with the values of their properties._

Create buttons to call methods to:

* _Feed it, play with it, and put it to sleep. These methods should modify the properties of a single Tamagotchi object — such as a food property._

* _Make time pass. Every time you press it, the food, happiness and sleep properties of all Tamagotchis should decrease. If any of these properties get to 0, the Tamagotchi object should report that it's dead._

* _At the very least, this app will include RESTful Index, New, Create, and Show routes._

## Setup/Installation Requirements

* _Clone this repo._
* _Open your terminal (e.g., Terminal or GitBash) and navigate to this project's production directory called "Tamagotchi.Solution"._
* _In the command line, run the command ``dotnet run`` to compile and execute the console application. Since this is a console application, you'll interact with it through text commands in your terminal._
* _Optionally, you can run ``dotnet build`` to compile this console app without running it._
* _If we want to run our project in production mode with a watcher, we can use a command line flag to specify that we want to run the "production" profile. ``dotnet watch run --launch-profile "production"``_
*  _Open the browser to [https://localhost:5001]. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this lesson: [Redirecting to HTTPS and Issuing a Security Certificate.](https://www.learnhowtoprogram.com/c-and-net/basic-web-applications/redirecting-to-https-and-issuing-a-security-certificate)_

## Test Instructions

* _Using a shell program, navigate from the root directory, "Tamagotchi.Solution," to the "PocketPet.Tests" directory._
* _Once in the "PocketPet.Tests" directory, type ``dotnet restore`` into the console._
* _After the restore process is complete, type ``dotnet test`` into the console. This will run all written tests and display the test results into the console to review._

## Known Bugs

* _Any known issues_

* _Please reach out with any questions or concerns to [eliot.lauren@gmail.com](eliot.lauren@gmail.com) [eluckie.d@gmail.com](eluckie.d@gmail.com), or [jannon.sielaff@gmail.com](jannon.sielaff@gmail.com)_

## License

_[MIT](https://opensource.org/license/mit/)_

Copyright (c) _2023_ _Eliot Gronstal, E Luckie, Jannon Sielaff_