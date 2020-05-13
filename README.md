# Task

Code an algorithm that finds a sequence of numbers in a binary tree with a largest sum.
Numbers in the sequence  must alternate between odd? and even?
Next step can go eather straight down, or down and to the left. 

1. You will start from the top and move downwards to an adjacent number as in below.
2. You are only allowed to walk downwards and diagonally.
3. You should walk over the numbers as evens and odds subsequently.

Your goal is to find the maximum sum if you walk the path. Assume that there is at least 1 valid path to
the bottom. If there are multiple paths giving the same sum, you can choose any of them.

# Usage 

``` sh
nuget restore
dotnet run -p AssetFinance/ input.txt
```


# Sample 

Sample Input:
1
8 9
1 5 9
4 5 2 3
Output:
Max sum: 16
Path: 1, 8, 5, 2

# Real imput 

215
192 124
117 269 442
218 836 347 235
320 805 522 417 345
229 601 728 835 133 124
248 202 277 433 207 263 257
359 464 504 528 516 716 871 182
461 441 426 656 863 560 380 171 923
381 348 573 533 448 632 387 176 975 449
223 711 445 645 245 543 931 532 937 541 444
330 131 333 928 376 733 017 778 839 168 197 197
131 171 522 137 217 224 291 413 528 520 227 229 928
223 626 034 683 839 052 627 310 713 999 629 817 410 121
924 622 911 233 325 139 721 218 253 223 107 233 230 124 233


# TODO

- [x] Read Input to datastructures
- [x] Write a test for a known case
- [x] Build an algorithm
- [x] Print output
  

# Notes and Ideas On solution?



Option 1)
Enumerate all valid paths
Sum them all up
Pick a winner...

- Consumes Heap

Option 2) 

Recursively walk the tree, 
accumulate the sums, and path taken 
Pick the winner
Consumes stack, and heap, cuz you need to remember the path

Option 3)

Use a datastructure trick?

Can there be a lazy calculation ?




# Obserbations 
- Immutable list could save some memory in representation
- Some Nodes exist as leaves to 2 parents. Can i use it some how?
- line Index of the number represents the number of digits to skip to build up the tree.
- line 0 means next 2 items are leaves
- line 5 means skip 5 next numbers. 


# Questions to answer...

How to represent data in memory?
How to create a data representation?
Can i conflate reading of data with an algorithm ?
Can i build up data structure bottom up?
Can i reconstruct the tree from a line on numbers?

