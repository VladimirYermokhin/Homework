import java.util.*;

public class PhoneBook {
    public static void main(String[] args) {
        // Создаем HashMap для хранения записей в телефонной книге
        HashMap<String, HashSet<String>> phoneBook = new HashMap<>();

        // Пример данных в телефонной книге
        String[][] contacts = {
                {"Иванов", "111-222-333"},
                {"Петров", "222-333-444"},
                {"Иванов", "555-666-777"},
                {"Сидоров", "777-888-999"}
        };

        // Заполняем телефонную книгу
        for (String[] contact : contacts) {
            String name = contact[0];
            String phoneNumber = contact[1];

            // Если имя уже есть в телефонной книге, добавляем номер телефона к существующему списку
            if (phoneBook.containsKey(name)) {
                HashSet<String> phoneNumbers = phoneBook.get(name);
                phoneNumbers.add(phoneNumber);
            } else { // Иначе создаем новую запись в телефонной книге
                HashSet<String> phoneNumbers = new HashSet<>();
                phoneNumbers.add(phoneNumber);
                phoneBook.put(name, phoneNumbers);
            }
        }

        // Создаем список записей телефонной книги, отсортированных по убыванию числа телефонов
        List<Map.Entry<String, HashSet<String>>> sortedEntries = new ArrayList<>(phoneBook.entrySet());
        sortedEntries.sort((entry1, entry2) -> Integer.compare(entry2.getValue().size(), entry1.getValue().size()));

        // Выводим результат
        for (Map.Entry<String, HashSet<String>> entry : sortedEntries) {
            System.out.println(entry.getKey() + ": " + entry.getValue());
        }
    }
}
