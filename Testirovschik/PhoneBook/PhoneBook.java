package org.example.TestJava;

//import java.util.HashMap;
//import java.util.HashSet;
//import java.util.Set;

import java.util.*;

public class PhoneBook {
    private String name;
    private String phone;
    private HashMap<String, Set<String>> phoneBook;

    public PhoneBook() {
        phoneBook = new HashMap<>();
        this.name = name;
        this.phone = phone;
        this.phoneBook = phoneBook;
    }

    public HashMap<String, Set<String>> getPhoneBook() {
        return phoneBook;
    }

    public void setPhoneBook(HashMap<String, Set<String>> phoneBook) {
        this.phoneBook = phoneBook;
    }

    /**
     * @apiNote Метод добавления в книгу
     * Если имя уже есть в книге, добавляется только телефон.
     * Если имени нет, создаем новую запись.
     */

    public void addEntry(String name, String phone) {
        if (phoneBook.containsKey(name)) {
            phoneBook.get(name).add(phone);
        } else {
            Set<String> phones = new HashSet<>();
            phones.add(phone);
            phoneBook.put(name, phones);
        }
    }

    /**
     * @param name
     * @apiNote Удаление записи
     */
    public void deleteEntry(String name) {
        phoneBook.remove(name);
    }

    /**
     * @param name
     * @param phone
     * @apiNote Удаление телефона
     * Если телефон последний, то удаляется вся запись
     */
    public void deletePhone(String name, String phone) {
        if (phoneBook.containsKey(name)) {
            phoneBook.get(name).remove(phone);
             if (phoneBook.get(name).isEmpty()) {
                phoneBook.remove(name);
            }
        }
    }

    /**
     * Вывод телефонной книги
     */
    public void printPhoneBook() {
        // Создаем список для сортировки по убыванию числа телефонов
        List<Map.Entry<String, Set<String>>> sortedEntries = new ArrayList<>(phoneBook.entrySet());

        // Сортируем список по количеству телефонов (в обратном порядке)
        sortedEntries.sort((entry1, entry2) -> Integer.compare(entry2.getValue().size(), entry1.getValue().size()));

        // Выводим телефонную книгу
        for (Map.Entry<String, Set<String>> entry : sortedEntries) {
            String name = entry.getKey();
            Set<String> phones = entry.getValue();
            System.out.println("Имя: " + name + ", Телефоны: " + phones);
        }
    }
}

