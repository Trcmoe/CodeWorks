# User input here
print("Please input the first number:")
n1 = float(input())
print("Please input the second number:")
n2 = float(input())
print("Please tell me the math method you want(1.+  2.-  3.*  4./ )(e.g:Input 1 as add):")
method: int = int(input())

if method > 4 or method < 1:
    print("Invalid input")
else:
    pass

if method == 1:
    result = n1 + n2
    print(n1, "+", n2, "=", result)
elif method == 2:
    result = n1 - n2
    print(n1, "-", n2, "=", result)
elif method == 3:
    result = n1 * n2
    print(n1, "*", n2, "=", result)
elif method == 4 and n2 != 0:
    result = n1 / n2
    print(n1, "/", n2, "=", result)
else:
    print("Invalid input")
