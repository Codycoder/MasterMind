# MasterMind

This is a solution to a coding challenge I received as a pre-interview step after applying to a job. The solution is a playable console app that I wrote in Visual Studio in C#.

# The Problem:

Create a C# console application that is a simple version of Mastermind.  The randomly generated answer should be four (4) digits in length, with each digit between the numbers 1 and 6.  After the player enters a combination, a minus (-) sign should be printed for every digit that is correct but in the wrong position, and a plus (+) sign should be printed for every digit that is both correct and in the correct position.  Nothing should be printed for incorrect digits.  The player has ten (10) attempts to guess the number correctly before receiving a message that they have lost.

# My Reaction:

I was excited about solving this problem, but also got initially muddled by the various details ("I think I know how to do x, but I'm not sure about y"). My tactic was to try to break it down into the simplest tasks and go from there. The random number generation I was familiar with but googled the exact syntax. I struggled a bit with getting the user input guesses read, converted to ints and populated first into an array and then later to list. I then tried to google the problem of comparing index postion and value between two lists and went down a lot of rabbit holes. I enjoy searching and reading MS Docs for C#/.NET info, and found reference to a .Contains method there.  

I tried a brute force technique by simply writitng out each check I needed done through if/else if statements but it didn't quite work right and wouldn't loop through. 

I told my bootcamp teachers about the problem. One of my teachers sat down and wrote a short program in JavaScript to show me how it could be solved and I looked right at his for loop and noticed that he used the list length as the second part of the function, which was cool because that meant the game could easily be modified to accept and use longer numbers. But I guess the rest of his for loop function didn't stick in my mind.

At that point I asked a friend for help and he told me to forget the foreach loop because it could only check one list. I set up the for loop to check through one index of one list just to think it through, and then my friend noted that if we changed that index to the same variable in the for loop, it would literally do all the work in just a few lines. Amazing! 

In retrospect, my blockers were: 

1. Thinking the solution was more complex than it was. Assuming it was some sort of next level answer I didn't even know about. 
2. Spending way too much time googling aspects of the problem instead of just working out the logic needed. Out of many different solutions on Stack Overflow, I only found one that was short, simple, and easy to understand. I didn't use it as I was all ready underway and going a different route. 

This was a fun exercise that was a good wake up call as to where my knowledge was and how I approached a problem. As with all my newly gained coding knowledge, this seems rather simple now and I wonder why I thought it was so hard. 


