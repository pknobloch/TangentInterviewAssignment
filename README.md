# Personal Project - Tangent Solutions Interview Assignment

This project is to demonstrate my ability to implement a system for Tangent Solutions based on specific requirements.

# Development Blog

----

## Day 1

I started with a .Net Core 1.1 application. It was new technology but I was confident that I could make it work. I managed to connect to the Tangent web service and got a token returned for my troubles. I started running the standard MVC template and hooked up the user login system with my new library...

That's when the troubles started. Sessions did not work like in previous version of .Net. I had a choice to make. I even upgraded my Visual Studio Community Edition to the latest version to allow for .Net Core 2 support.

## Day 2

This is not really an R&D type project so I decided to roll a new MVC website with .Net Standard. 4.7.1 is installed with the newest version of VS2017, so I may as well use it. I already have a problem because my class libraries won't let me choose above .Net framework version 2. I'm going to just integrate the logic into my MVC project for now instead of battle against VS.

## Day 2 - Part 2

Today went fantastically. Most of my code was simple to copy across and I spent the rest of my time writing features. I started writing unit tests but eventually gave up because of time restraints. I managed to end the day with a list of employees and a basic filter.

## Day 3

I received feedback on how the filters parameters work. I completed them and noticed some subtle requirements. Certain users can view more details, so I made the assumption that Senior level users can view them. I then added the extra details (reviews and leave requests) to the employee details page and limited them based on Senior level. I also made the page an accordian because it was very busy.
