# Bust-The-Ghost
In this assignment we had to use Unity to implement/reproduce  "Bust the Ghost"  game.  
We should Use Unity to create a 8x 20 grid  
Have the ghost be placed in one of the cells according to a prior distribution of Ghost over location P(Ghost).  
Use a uniform distribution  to start with.  
When clicking  a cell, the user/player gets a color red/green/orange/yellow depending on how  the far is the ghost is from the clicked cell.   
On the ghost: red  
1 or 2 cells away: orange   
3 or 4 cells away: yellow  
5+ cells away: green  
For this, we needed to define and use a conditional probability distribution P(Color/Distance from Ghost).  
Then, we had to use this probability to decide on the color to display.  
After each click "t" the  Posterior Probability of the Ghost P(Ghost/ Color) should be updated  and displayed on the cells using Bayesian inference
P(Ghost_t)=P(Ghost/Color_t)=P(Ghost_t-1)*P(Color/Distance from Ghost).  
P(Ghost_0)= P(Ghost/Color_0)= P(Ghost) the prior probability.   
User can decide to "bust" a cell if ghost is in the cell; the player wins otherwise he/she looses. 

# Link to the Youtube video:
https://youtu.be/D6SHn-jlO00
