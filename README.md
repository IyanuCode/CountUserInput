# 🧾 User Input App - C# Console Application

This is a simple C# console application that accepts a user's string input, processes it by removing spaces, converting to lowercase, and identifying unique and duplicate characters. The final result is a count of processed characters based on their uniqueness in the input.

---

## 🚀 Features

- Accepts string input from the user.
- Validates if the input is not null, empty, or whitespace.
- Removes all spaces and converts the string to lowercase.
- Uses `IndexOf` and `LastIndexOf` to determine if characters are unique or duplicates.
- Builds a new string of processed characters.
- Displays the count of processed characters.

---

## 💡 How It Works

1. Prompts the user for input.
2. Validates the input.
3. If valid:
   - Removes all spaces.
   - Converts the input to lowercase.
   - Iterates through each character to:
     - Identify unique characters (those that appear only once).
     - Add non-unique characters only once if they are duplicates.
4. Outputs the length of the resulting character set.

---

## 🧪 Example

```bash
Welcome to the User Input App!
Please enter a string to proceed:
> Programming

The number of word you entered is: 8
```

## Author
Adeusi Iyanu Emmmanuel - https://github.com/IyanuCode