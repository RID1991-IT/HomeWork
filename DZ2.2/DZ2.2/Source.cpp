#include <iostream>

using namespace std;

int main()
{
	setlocale(LC_ALL, "rus");

	const double PI = 3.14;
	double l, r, s;
	


	cout << "\t\t������2" << endl;
	cout << " �� �������� ����� ���������� ����� ������� ����� �� ������� S = pi*R2 \n �������������� �� ������� ����� ���������� : L = 2 * pi * R" << endl;
	system("pause");
	cout << " ������� ����� L "; cin >> l;cout << endl;
	cout << " ������ ��������� R = L/2Pi\n"; r = l / 2 * PI; cout << endl;
	cout << " R= " << r << endl;

	cout << "\n ������� �����\n S = pi*R2  " << endl;
	system("pause");

	s = PI * (r * r);

	cout << " S= " << s << endl;
	


}
