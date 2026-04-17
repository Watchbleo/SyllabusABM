// Function to validate that inputs are numbers
function validateNumber(value) {
    const num = Number(value);
    if (isNaN(num)) {
        throw new Error(`Invalid input: "${value}" is not a number.`);
    }
    return num;
}

// Function to add two numbers
function add(a, b) {
    return a + b;
}

// Function to subtract two numbers
function subtract(a, b) {
    return a - b;
}

// Example usage:
try {
    // Example inputs (you can replace these with prompt() in a browser)
    let input1 = "10"; // could be from user input
    let input2 = "4";

    // Validate and convert inputs
    let num1 = validateNumber(input1);
    let num2 = validateNumber(input2);

    // Perform operations
    let sum = add(num1, num2);
    let difference = subtract(num1, num2);

    // Output results
    console.log(`Sum of ${num1} and ${num2} is: ${sum}`);
    console.log(`Difference of ${num1} and ${num2} is: ${difference}`);

} catch (error) {
    console.error(error.message);
}

