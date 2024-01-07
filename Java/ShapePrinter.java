import java.util.Scanner;

abstract class Shape {
    public abstract void printShape();
}

class RightTriangle extends Shape {
    private final int size;

    public RightTriangle(int size) {
        this.size = size;
    }

    @Override
    public void printShape() {
        for (int i = 0; i < size; i++) {
            for (int j = 0; j <= i; j++) {
                if (i == size - 1 || j == 0 || j == i) {
                    System.out.print("* ");
                } else {
                    System.out.print("  ");
                }
            }
            System.out.println();
        }
    }
}

class Square extends Shape {
    private final int size;

    public Square(int size) {
        this.size = size;
    }

    @Override
    public void printShape() {
        for (int i = 0; i < size; i++) {
            for (int j = 0; j < size; j++) {
                if (i == 0 || i == size - 1 || j == 0 || j == size - 1) {
                    System.out.print("* ");
                } else {
                    System.out.print("  ");
                }
            }
            System.out.println();
        }
    }
}

public class ShapePrinter {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("请输入边长: ");
        int size = scanner.nextInt();

        if (size <= 0) {
            System.out.println("请输入正整数。");
            return;
        }

        Shape triangle = new RightTriangle(size);
        Shape square = new Square(size);

        System.out.println("\n三角形:");
        triangle.printShape();

        System.out.println("\n正方形:");
        square.printShape();

        scanner.close();
    }
}