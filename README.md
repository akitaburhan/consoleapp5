# consoleapp5
List of Strings with Duplicates:

The duplicateList contains some duplicate strings (e.g., "apple" and "banana" appear more than once).
User Input:

The program prompts the user to enter text they wish to search for in the list.
Loop through List:

The program uses a for loop to iterate through duplicateList and checks for matches with searchText.
For each match, it displays the index where the match was found.
The matchFound flag is set to true if at least one match is found.
No Match Found:

After the loop, if matchFound is still false, the program outputs that the user's input is not on the list.
Case-Insensitive Search:

Using StringComparison.OrdinalIgnoreCase ensures that the search is not case-sensitive.
Example Run:
If the list is ["apple", "banana", "cherry", "apple", "date", "banana"]:

If the user enters "apple", it will output:

perl
Match found at index 0
Match found at index 3
If the user enters "banana", it will output:

perl
Match found at index 1
Match found at index 5
If the user enters "grape", it will output:

csharp
input is not on the list.
