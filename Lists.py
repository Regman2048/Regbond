def number_list_operations():
    """Collects numbers from the user, performs operations, and displays results."""
    numbers = []
    print("Enter numbers for the list (enter 'done' when finished):")

    while True:
        input_str = input().lower()
        if input_str == "done":
            break
        try:
            number = float(input_str)
            numbers.append(number)
        except ValueError:
            print("Invalid input. Please enter a number or 'done'.")

    if numbers:
        # 1. Compute the sum
        sum_of_numbers = sum(numbers)
        print(f"\nSum of the numbers: {sum_of_numbers}")

        # 2. Compute the average
        average_of_numbers = sum(numbers) / len(numbers)
        print(f"Average of the numbers: {average_of_numbers}")

        # 3. Find the maximum number
        maximum_number = max(numbers)
        print(f"Maximum number in the list: {maximum_number}")

        # 4. Find the smallest positive number
        positive_numbers = [n for n in numbers if n > 0]
        if positive_numbers:
            smallest_positive = min(positive_numbers)
            print(f"Smallest positive number in the list: {smallest_positive}")
        else:
            print("There are no positive numbers in the list.")

        # 5. Sort the numbers and display the sorted list
        numbers.sort()
        print("Sorted list of numbers:")
        print(*numbers)  # Using * to unpack the list for printing on one line

    else:
        print("No numbers were entered in the list.")

if __name__ == "__main__":
    number_list_operations()