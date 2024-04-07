import pandas as pd

# Генерация данных
import random
lst = ['robot'] * 10
lst += ['human'] * 10
random.shuffle(lst)
data = pd.DataFrame({'whoAmI': lst})

# Получаем уникальные значения из столбца 'whoAmI'
unique_values = data['whoAmI'].unique()

# Создаем пустой DataFrame для one hot представления
one_hot_data = pd.DataFrame()

# Для каждого уникального значения создаем новый столбец в one hot DataFrame
for val in unique_values:
    # Создаем столбец с названием уникального значения
    one_hot_data[val] = (data['whoAmI'] == val).astype(int)

# Выводим результат
print(one_hot_data.head())
