# Bingo Board Simulation Tools

I got heavily distracted while working on my resume, and decided to code this up that evening instead. I started with the question of "What are the chances that a bingo board with 10 spaces filled would be a winning board?"

## The Assumptions

* Boards are 5 x 5.
* There is no "free space" in the center.
* The contents of spaces are not simulated. There are no numbers on the spaces.
* The drawing of numbers is not simulated. Only board states (spaces being filled or not) are considered.
* Space filling order is not considered. When it says "assuming the xth space is the win", it's actually only considering boards with one win condition and assuming that whatever would have been the draw is what finished the win condition.
* Win conditions are: any of the 5 rows filled. Any of the 5 columns filled. Either diagonal filled. 12 win conditions total.

## What did you do?

Well, this implementation is brute-force. I didn't have the math knowledge required to figure out these kinds of questions, so I decided that I would build tools that help analyze board states and then just iterate through every possible state. The number of possible states is small enough that this isn't much of an issue on modern hardware. There's only 33,554,432 (2^25) board states. The most expensive methods are probably the methods that count filled spaces and the print method. These, at most, check every bit (25) of a board, and if these are mapped over the entire set of boards (33554432), then there will be around 838,860,800 iterations. (These are constant values though, soooo technically O(1)?)

## What would you do differently?

Well, I would remove some assumptions and try to generalize the tools over more types. For example, what if we wanted to see how likely it would be for a 7 x 7 board with 14 spaces have a double win? These tools won't help with that. 

Adding a board type to have a free space in the center would be more typical of real world bingo boards. If I did things differently, I would have accounted for this. In fact, having a guaranteed filled space in the center should cut the number of possible board states in half (2^24).

Adding bingo boards with numbers would be really cool! Searching through the entire set of board states of bingo boards with numbers would be a very uncool! According to Wikipedia [citation needed], American bingo uses 5 x 5 boards with the numbers 1 through 75 on them. The number of possible boards, including filled states jumps up to something like 2.58E19 (2^75`choose`24). If I implemented these kinds of boards, I would take a random sampling approach instead of searching the entire set of boards. The numbers would be less accurate, but users could always dedicate more cycles to trying more boards for more accuracy, right?

Going through the trouble of adding boards with numbers means that I would also have to go through the trouble of actually simulating number drawing (or at least passing a list of random draws to compare boards against).

## What I learned

C# is an enjoyable language to use. Good job, C# team. :)