﻿//1
int piterburg = 5598486;
int moskva = 13015126;
Console.WriteLine($"В Москве на {(moskva - piterburg) / 1000} жителей больше, чем в Питербурге");
/*Пришлось импровизировать так как в задание не коректно укзан вопрос.
 * "НА сколько тысяч жителей МЕНЬШЕ в Москве"*/

//2
Decimal perYear = 260548.56895m;//За год
Decimal perMonth = perYear / 12;//За месяц
Decimal ndfl = perMonth / 100 * 13;//НДФЛ от з\п за месяц
Console.WriteLine($"Работник за месяц заработал {perMonth}");
Console.WriteLine($" работник за месяц раработал с вычетом НДФЛ {perMonth - ndfl}");