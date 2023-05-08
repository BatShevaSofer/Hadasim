#include <iostream>
#include "Triangular.h"
#include "Rectangle.h"

using namespace std;


void main()
{
	int x, y, w, h;
	cout << "Enter the option:" << endl;
	cout << "1: Rectangle tower    2: Triangular tower    3: Exit" << endl;
	cin >> x;
	while (x < 1 || x > 3)
	{
		cout << "Enter the exist option!" << endl;
		cout << "1: Rectangle tower    2: Triangular tower    3: Exit" << endl;
		cin >> x;
	}
	while (x != 3)
	{
		cout << "Enter Width:";
		cin >> w;
		cout << "Enter height:";
		cin >> h;
		if (x == 1)
		{
			Rectangle r = Rectangle(w, h);
			if (abs(w - h) > 5)
				r.printArea();
			else
				r.printPerimeter();
		}
		else
		{
			Triangular t = Triangular(w, h);
			cout << "Enter the option:" << endl;
			cout << "1: Calculate the perimeter of the triangle    2: The triangle print" << endl;
			cin >> y;
			while (y < 1 || x > 2)
			{
				cout << "Enter the exist option!" << endl;
				cout << "1: Calculate the perimeter of the triangle    2: The triangle print" << endl;
				cin >> y;
			}
			if (y == 1)
				t.printPerimeter();
			else
				t.printTriangular();
		}
		cout << "Enter the option:" << endl;
		cout << "1: Rectangle tower    2: Triangular tower    3: Exit" << endl;
		cin >> x;
		while (x < 1 || x > 3)
		{
			cout << "Enter the exist option!" << endl;
			cout << "1: Rectangle tower    2: Triangular tower    3: Exit" << endl;
			cin >> x;
		}
		
	}
}