package org.example.TestJava;
import java.util.Scanner;


public class Main {
    public static void main(String[] args) {
       PhoneBook phoneBook = new PhoneBook();
       phoneBook.addEntry("Иванов", "123456");
        phoneBook.addEntry("Петров", "234567");
        phoneBook.addEntry("Сидоров", "345678");
        phoneBook.addEntry("Иванов", "456789");
        phoneBook.addEntry("Петров", "567890");
        phoneBook.addEntry("Иванов", "678901");

        Scanner scanner = new Scanner(System.in);
        while (true) {
            System.out.println("\nМеню:");
            System.out.println("1. Добавить запись");
            System.out.println("2. Удалить запись");
            System.out.println("3. Удалить телефон");
            System.out.println("4. Вывести телефонную книгу");
            System.out.println("5. Выход");
            System.out.print("Выберите действие: ");

            int choice = scanner.nextInt();
            scanner.nextLine(); // Todo Чтобы считать символ новой строки после ввода числа

            String name, phone;
            switch (choice) {
                case 1:
                    System.out.print("Введите имя: ");
                    name = scanner.nextLine();
                    System.out.print("Введите телефон: ");
                    phone = scanner.nextLine();
                    phoneBook.addEntry(name, phone);
                    break;
                case 2:
                    System.out.print("Введите имя для удаления: ");
                    name = scanner.nextLine();
                    phoneBook.deleteEntry(name);
                    break;
                case 3:
                    System.out.print("Введите имя: ");
                    name = scanner.nextLine();
                    System.out.print("Введите телефон для удаления: ");
                    phone = scanner.nextLine();
                    phoneBook.deletePhone(name, phone);
                    break;
                case 4:
                    System.out.println("Телефонная книга:");
                    phoneBook.printPhoneBook();
                    break;
                case 5:
                    System.out.println("Выход из программы.");
                    scanner.close();
                    System.exit(0);
                default:
                    System.out.println("Некорректный выбор, повторите.");
            }
        }
    }
}
