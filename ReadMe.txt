Задание 6

Исправленный код
class Instantiator
{
    public T instance;
    public Instantiator()
    {
        instance = default(T);
    }
}

Задание 9

Есть таблица students с колонками
id int
name varchar
created_at datetime
parent_id int

Напишите sql для получения
a) количества всех студентов
b) количества студентов с именем Иван
c) количества студентов созданных после 1 сентября 2020 года
d) максимального кол-ва детей у одного родителя

Решение
a) SELECT COUNT(id) * FROM students;
b) SELECT COUNT(id) * FROM students WHERE name = 'Иван';
c) SELECT COUNT(id) * FROM students WHERE created_at datetime
> 2020-09-01 00:00:00';
d) SELECT MAX COUNT(id), parent_id FROM students GROUP BY parent_id ; "Не уверен что последнее задание решено верно"
