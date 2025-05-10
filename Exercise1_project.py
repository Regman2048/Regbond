# Get the grade percentage from the user
try:
    grade_percentage = float(input("What is your grade percentage? "))
except ValueError:
    print("Invalid input. Please enter a number.")
    exit()

# Determine the initial letter grade
if grade_percentage >= 90:
    letter = "A"
elif grade_percentage >= 80:
    letter = "B"
elif grade_percentage >= 70:
    letter = "C"
elif grade_percentage >= 60:
    letter = "D"
else:
    letter = "F"

# Determine if the user passed
if grade_percentage >= 70:
    print("Congratulations! You passed the course.")
else:
    print("Keep trying! You'll get it next time.")

# Determine the sign (+ or -)
sign = ""
if letter != "F" and letter != "A":
    last_digit = int(grade_percentage) % 10
    if last_digit >= 7:
        sign = "+"
    elif last_digit < 3:
        sign = "-"
elif letter == "A":
    last_digit = int(grade_percentage) % 10
    if last_digit < 3 and grade_percentage < 100:
        sign = "-"

# Display the final grade
print(f"Your letter grade is {letter}{sign}.")