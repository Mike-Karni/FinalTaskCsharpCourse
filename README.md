# Решение контрольной работы по курсу "Знакомство с языками программирования"

Решение выполнено на языке программирования С#

Условие задачи:

**Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры**:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []

# Описание алгоритма решения задачит
1. задаем новый массив длиной первоначального массива
2. записываем метод, который идёт циклом по первому массиву и записывает в элементы второго массива только те элементы , размеры которых <= 3
3. пишем метод PrintArray
4. вызываем метод из пункта 2 и 3.