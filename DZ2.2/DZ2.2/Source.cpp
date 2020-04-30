#include <iostream>

using namespace std;

int main()
{
	setlocale(LC_ALL, "rus");

	const double PI = 3.14;
	double l, r, s;
	


	cout << "\t\tЗадача2" << endl;
	cout << " По заданной длине окружности найти площадь круга по формуле S = pi*R2 \n радиувычислить из формулы длины окружности : L = 2 * pi * R" << endl;
	system("pause");
	cout << " ВВедите длину L "; cin >> l;cout << endl;
	cout << " Радиус равняется R = L/2Pi\n"; r = l / 2 * PI; cout << endl;
	cout << " R= " << r << endl;

	cout << "\n Площадь равна\n S = pi*R2  " << endl;
	system("pause");

	s = PI * (r * r);

	cout << " S= " << s << endl;
	


}
