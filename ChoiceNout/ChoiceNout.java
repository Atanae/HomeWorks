/*-Подумать над структурой класса Ноутбук для магазина техники - выделить поля и
методы. Реализовать в java.
- Создать множество ноутбуков.
- Написать метод, который будет запрашивать у пользователя критерий (или критерии)
фильтрации и выведет ноутбуки, отвечающие фильтру. Критерии фильтрации можно
хранить в Map. Например:
“Введите цифру, соответствующую необходимому критерию:
1 - ОЗУ
2 - Объем ЖД
3 - Операционная система
4 - Цвет …
- Далее нужно запросить минимальные значения для указанных критериев - сохранить
параметры фильтрации можно также в Map.
- Отфильтровать ноутбуки их первоначального множества и вывести проходящие по
условиям.*/

import java.util.*;

class Notebook {
    private String model;
    private int ram;
    private int storage;
    private String operatingSystem;
    private String color;

    public Notebook(String model, int ram, int storage, String operatingSystem, String color) {
        this.model = model;
        this.ram = ram;
        this.storage = storage;
        this.operatingSystem = operatingSystem;
        this.color = color;
    }

    public String getModel() {
        return model;
    }

    public int getRam() {
        return ram;
    }

    public int getStorage() {
        return storage;
    }

    public String getOperatingSystem() {
        return operatingSystem;
    }

    public String getColor() {
        return color;
    }

    public static Set<Notebook> addNotebooks(Scanner scanner) {
        Set<Notebook> notebooks = new HashSet<>();

        // Добавляем предварительные данные
        notebooks.add(new Notebook("Dell XPS", 16, 512, "Windows 10", "Silver"));
        notebooks.add(new Notebook("MacBook Pro", 8, 256, "macOS", "Space Gray"));
        notebooks.add(new Notebook("HP Spectre", 12, 1024, "Windows 11", "Black"));

        // Добавляем свои данные
        while (true) {
            System.out.println("Добавление нового ноутбука:");
            System.out.print("Введите модель (или 'exit' для завершения): ");
            String model = scanner.nextLine();

            if (model.equalsIgnoreCase("exit")) {
                break;
            }

            System.out.print("Введите объем ОЗУ: ");
            int ram = scanner.nextInt();

            System.out.print("Введите объем ЖД: ");
            int storage = scanner.nextInt();

            System.out.print("Введите операционную систему: ");
            scanner.nextLine(); // Чтение новой строки после числа
            String operatingSystem = scanner.nextLine();

            System.out.print("Введите цвет: ");
            String color = scanner.nextLine();

            notebooks.add(new Notebook(model, ram, storage, operatingSystem, color));
        }

        return notebooks;
    }

    public static Set<Notebook> filterNotebooks(Set<Notebook> notebooks, Map<String, Object> filters) {
        // Реализуйте фильтрацию ноутбуков по заданным критериям
        Set<Notebook> filteredNotebooks = new HashSet<>(notebooks);

        for (Map.Entry<String, Object> entry : filters.entrySet()) {
            String filterKey = entry.getKey();
            Object filterValue = entry.getValue();

            filteredNotebooks.removeIf(notebook -> {
                switch (filterKey) {
                    case "RAM":
                        return notebook.getRam() < (int) filterValue;
                    case "Storage":
                        return notebook.getStorage() < (int) filterValue;
                    case "OperatingSystem":
                        return !notebook.getOperatingSystem().equalsIgnoreCase((String) filterValue);
                    case "Color":
                        return !notebook.getColor().equalsIgnoreCase((String) filterValue);
                    case "All":
                        return true; // В данном примере возвращаем все ноутбуки без фильтрации
                    default:
                        return false;
                }
            });
        }    
        

        return filteredNotebooks;
    }

    public static void main(String[] args) {
        Set<Notebook> notebooks = addNotebooks(new Scanner(System.in));

        //  критерии фильтрации
        Map<String, Object> filters = getFilters();
        
        // Фильтруем ноутбуки и выводим результат
        Set<Notebook> filteredNotebooks = filterNotebooks(notebooks, filters);
        if (filteredNotebooks.isEmpty()) {
            System.out.println("Подходящих ноутбуков не найдено.");
        } else {
            System.out.println("Результаты фильтрации:");
            filteredNotebooks.forEach(notebook -> System.out.println("Модель: " + notebook.getModel() +
                    ", ОЗУ: " + notebook.getRam() +
                    ", Объем ЖД: " + notebook.getStorage() +
                    ", Операционная система: " + notebook.getOperatingSystem() +
                    ", Цвет: " + notebook.getColor()));
        }
    }

    private static Map<String, Object> getFilters() {
        Scanner scanner = new Scanner(System.in);
        Map<String, Object> filters = new HashMap<>();
        System.out.println("Выберите критерии фильтрации:");
        System.out.println("1 - ОЗУ");
        System.out.println("2 - Объем ЖД");
        System.out.println("3 - Операционная система");
        System.out.println("4 - Цвет");
        System.out.println("5 - Показать все ноутбуки");

        while (true) {
            System.out.print("Введите номер критерия (или 0 для завершения): ");
            int choice = scanner.nextInt();

            if (choice == 0) {
                break;
            }
            if (choice == 5) {
                filters.clear();
                break;
            }          
            String filterKey = "";
            Object filterValue = null;

            
            

            switch (choice) {
                case 1:
                    filterKey = "RAM";
                    System.out.print("Введите минимальный объем ОЗУ: ");
                    filterValue = scanner.nextInt();
                    break;
                case 2:
                    filterKey = "Storage";
                    System.out.print("Введите минимальный объем ЖД: ");
                    filterValue = scanner.nextInt();
                    break;
                case 3:
                    filterKey = "OperatingSystem";
                    System.out.print("Введите операционную систему: ");
                    scanner.nextLine(); // Чтение новой строки после числа
                    filterValue = scanner.nextLine();
                    break;
                case 4:
                    filterKey = "Color";
                    System.out.print("Введите цвет: ");
                    scanner.nextLine(); // Чтение новой строки после числа
                    filterValue = scanner.nextLine();
                    break;
                default:
                    System.out.println("Некорректный выбор. Пожалуйста, выберите снова.");
            }

            filters.put(filterKey, filterValue);
        }
        return filters;
    }
}