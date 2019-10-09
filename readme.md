# Problem Description

We give our program a string of lowercase English letters that is repeated infinitely many times.

Given an integer `n` find and count the number of letter `a`'s in the first `n` letters of the infinite string.

For example, if the string `s="ababa"` and `n=10` the substring we consider is `ababaababa` which are the first `n` characters of the infinite string. There are **6** occurrences of `a` in the substring.

Our program then will use the number of occurences and print a string based on the following condition:

- if the number of occurrences is multiple of 3 it will print `Fizz`
- if the number of occurrences is multiple of 5 it will print `Buzz`
- if the number of occurrences is multiple of 3 and 5 it will print `FizzBuzz`
- if the number of occurrences is neither multiple of 3 or 5 it will print the number

## Constraints

- the input string should have a length between 1 and 100 otherwise the programm will print 0
- the number of letter `n` to analyse needs to be between 0 and Int.MaxValue

## Examples

### Sample Input 1

`inputString = "ababa"`

`letterToAnalyse = 11`

`Sample Output -> 7`

### Sample Input 2

`inputString = "ababa"`

`letterToAnalyse = 10`

`Sample Output -> Fizz`

### Sample Input 2

`inputString = "aaaaa"`

`letterToAnalyse = 10`

`Sample Output -> Buzz`

### Sample Input 3

`inputString = "ababa"`

`letterToAnalyse = 25`

`Sample Output -> FizzBuzz`

## Repository Structure

- **RepeatedString** folder contains the repository that will be presented to the candidate. The solution of the problem is given and it's been coded badly inside the Main method of the program. The idea is to let the candidate refactor and improve the solution as he thinks appropriate to make it testable, applying SOLID principles and patterns.

- **RepeatedStringSolution** contains a project that attempts at a solution that is testable and contains the use of different patterns