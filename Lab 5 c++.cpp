// Lab 5 c++.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
using namespace std;

int main()
{
    int d1, d2, d3, d4;
    bool check;
    for (int a = 10; a < 100; a++)
    {
        d1 = a / 10;
        d2 = a % 10;
        for (int b = 10; b < 100; b++)
        {
            d3 = b / 10;
            d4 = b % 10;
            check = d4 != d3 && d4 != d2 && d4 != d1 && d3 != d2 && d3 != d1 && d2 != d1;
            if (check) {
                cout << d1 * 1000 + d2 * 100 + d3 * 10 + d4 << endl;
            }
        }
    }
}

// Запуск программы: CTRL+F5 или меню "Отладка" > "Запуск без отладки"
// Отладка программы: F5 или меню "Отладка" > "Запустить отладку"

// Советы по началу работы 
//   1. В окне обозревателя решений можно добавлять файлы и управлять ими.
//   2. В окне Team Explorer можно подключиться к системе управления версиями.
//   3. В окне "Выходные данные" можно просматривать выходные данные сборки и другие сообщения.
//   4. В окне "Список ошибок" можно просматривать ошибки.
//   5. Последовательно выберите пункты меню "Проект" > "Добавить новый элемент", чтобы создать файлы кода, или "Проект" > "Добавить существующий элемент", чтобы добавить в проект существующие файлы кода.
//   6. Чтобы снова открыть этот проект позже, выберите пункты меню "Файл" > "Открыть" > "Проект" и выберите SLN-файл.
