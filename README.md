# Контрольная работа
## Задача: 
### Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
## Описание решения алгоритма:
### В начале программы объявляется два массива: изначальный и второй такой же длины. Далее мы прописываем метод, в котором цикл соразмерный длине массива, внутри самого цикла проверка условия if ( <=3 ), если да элемент первого массива заносится в count элемент второго массива. Это делается для того чтобы переменная count  поочередно передавала значение из первого массива во второй и чтобы в дальнейшем не было пробелов. После присвоения увеличивается переменная count на 1 и возвращается к циклу for в котором i увеличивается на 1. И так проверяется до конца массива. И в конце вывод второго массива.
### Блок-схема алгоритма в папке Flowchart в двух файлах разных расширениях.

