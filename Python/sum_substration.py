# Program to calculate sum and subtraction of two numbers

def add_numbers(a, b):
    """Return the sum of two numbers."""
    return a + b

def subtract_numbers(a, b):
    """Return the subtraction of two numbers (a - b)."""
    return a - b

def main():
    try:
        # Get user input
        num1 = float(input("Enter the first number: "))
        num2 = float(input("Enter the second number: "))

        # Perform operations
        sum_result = add_numbers(num1, num2)
        sub_result = subtract_numbers(num1, num2)

        # Display results
        print(f"Sum of {num1} and {num2} is: {sum_result}")
        print(f"Subtraction of {num1} - {num2} is: {sub_result}")

    except ValueError:
        print("Invalid input! Please enter numeric values only.")

if __name__ == "__main__":
    main()

