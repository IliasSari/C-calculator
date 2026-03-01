### Key Challenges Tackled:
* **Division by Zero:** Implementing logic to prevent application crashes when a user attempts to divide by zero.
* **Input Validation:** Ensuring the program only accepts numeric values.
* **Flow Control:** Using `switch` statements for clean, readable branching logic.

---

## 🚀 Technical Features

### 1. Robust Arithmetic Logic
The calculator supports:
* **Addition (+)**
* **Subtraction (-)**
* **Multiplication (*)**
* **Division (/)** with a built-in safety check.



### 2. Error Handling (The Junior Edge)
Instead of a simple `double.Parse()`, this project uses `double.TryParse()` to ensure that the application handles non-numeric characters gracefully without throwing exceptions.

### 3. Loop-Based UI
The application runs in a `while` loop, allowing the user to perform multiple calculations without restarting the program.
