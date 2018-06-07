# C-Sharp-Practice

This repository contains different, small C# projects I've worked on. 


# input
This project simply takes in a sentence & prints the reverse. 

# Dog Food Bowl Automation Machine Simulator
This project simulates a system that periodically checks the weight of a bowl (dog bowl, candy dish...) and adds more food if the weight is under a certain threshold. 

Since this is a simple simulator there are a few notes to be made:
- I used 2 random number generators: 
  1) To act as the weight of the bowl
  2) To act as the new weight of the bowl when food is added to it
Because of this, sometimes the weight will jump from, for example, 6 -> 8 without an indication that food has been added. This is because of the RNG getting a new random number. It just so happens that this number is higher than the previous weight. 

- The simulator currently checks the weight of the bowl every 3 seconds. If/ when the full system is implemented, the user can choose how often the program checks the bowl's weight (1 hr, 3x's per day...). 
