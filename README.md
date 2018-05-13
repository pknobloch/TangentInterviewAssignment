# Personal Project - Tangent Solutions Interview Assignment

This project is to demonstrate my ability to implement a system for Tangent Solutions based on specific requirements.

# Day 1

I started with a .Net Core 1.1 application. It was new technology but I was confident that I could make it work. I managed to connect to the Tangent web service and got a token returned for my troubles. I started running the standard MVC template and hooked up the user login system with my new library...

That's when the troubles started. Sessions did not work like in previous version of .Net. I had a choice to make. I even upgraded my Visual Studio Community Edition to the latest version to allow for .Net Core 2 support.

# Day 2

This is not really an R&D type project so I decided to roll a new MVC website with .Net Standard. 4.7.1 is installed with the newest version of VS2017, so I may as well use it. I already have a problem because my class libraries won't let me choose above .Net framework version 2. I'm going to just integrate the logic into my MVC project for now instead of battle against VS.
