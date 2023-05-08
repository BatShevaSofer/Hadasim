#include "Triangular.h"
#include <math.h>
#include <iostream>
using namespace std;


Triangular::Triangular(int w, int h)
{
	this->height = h;
	this->width = w;
}
void Triangular::printPerimeter()
{
	int side = sqrt(pow(this->width / 2, 2) + pow(this->height, 2));//משפט פיתגורס
	cout << side * 2 + this->width;
}
void Triangular::printTriangular()
{
	if (this->width % 2 == 0 || this->height * 2 < this->width)
	{
		cout << "We can't print the triangular";
		return;
	}
	else
	{
		int i, j, numLines, numLinesAbove, num = 1, spaces;
		for (i = 0; i < this->width; i++)
		{
			if (i == this->width / 2)
				cout << "*";
			else cout << " ";

		}
		cout << endl;
		num += 2;
		if ((this->width - 2) / 2 == 0) {//בלי הבדיקה הזו התוכנית יכולה ליפול בשורת ההשמה של numLines כי מחלקים ב0
			cout << "***";
				return;
		}

		numLines = (this->height-2)/((this->width - 2) / 2);
		numLinesAbove = (this->height - 2) % ((this->width - 2) / 2) + numLines;
		for (i = 0; i < numLinesAbove; i++)//הדפסת בלוק השורות העליונות
		{
			for (j = 0; j < this->width; j++)
			{
				spaces = this->width - num;
				if (j < spaces / 2 || j >= spaces / 2 + num)
					cout << " ";
				else
					cout << "*";
			}
			cout << endl;
		}
		num += 2;
		while (num < this->width)//הדפסת בלוקי השורות האמצעיים
		{
			for (i = 0; i < numLines; i++)
			{
				for (j = 0; j < this->width; j++)
				{
					spaces = this->width - num;
					if (j < spaces / 2 || j >= spaces / 2 + num)
						cout << " ";
					else
						cout << "*";
				}
				cout << endl;
			}
			num += 2;
		}
		for (i = 0; i < this->width; i++)//הדפסת השורה האחרונה
			cout << "*";
	}
}
