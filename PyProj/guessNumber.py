import random

randomNumber = random.randint(0, 10)

for i in range(5):
    guess = input("请输入一个数字(范围：0~10)：")
    if not guess.isdigit():
        print("您需要输入数字！")
        continue

    guess = int(guess)

    if guess == randomNumber:
        print("恭喜您猜对了！")
        break
    elif guess < randomNumber:
        print("您猜的数字太小了！")
    else:
        print("您猜的数字太大了！")
    left = 5 - i
    if left > 0:
        print(f"您还有{left}次机会。")
    else:
        print(f"您已经用完了所有机会，正确答案是{randomNumber}。")
