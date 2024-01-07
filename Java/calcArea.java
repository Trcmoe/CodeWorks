import java.util.Scanner;

public class calcArea {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.println("请输入长方形的长度: ");
        double length = scanner.nextDouble();

        System.out.println("请输入长方形的宽度: ");
        double width = scanner.nextDouble();

        Rectangle rectangle = new Rectangle(length, width);
        System.out.println("长方形的面积是: " + rectangle.calculateArea());
    }

    private abstract static class Shape {
        public abstract double calculateArea();
    }
    
    private static class Rectangle extends Shape {
        private double length;
        private double width;

        public Rectangle(double length, double width) {
            this.length = length;
            this.width = width;
        }

        @Override
        public double calculateArea() {
            return length * width;
        }
    }
}
