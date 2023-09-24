Decimal perYear = 260548.56895m;//За год
Decimal perMonth = perYear / 12;//За месяц
Decimal ndfl = perMonth / 100 * 13;//НДФЛ от з\п за месяц
Console.WriteLine($"Работник за месяц заработал {perMonth}");
Console.WriteLine($" работник за месяц раработал с вычетом НДФЛ {perMonth - ndfl}");