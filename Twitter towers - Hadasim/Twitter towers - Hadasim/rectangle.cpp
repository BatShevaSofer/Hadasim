
#include "Rectangle.h"
#include <iostream>
using namespace std;

Rectangle::Rectangle(int w, int h)
{
	this->height = h;
	this->width = w;
}
void Rectangle::printArea() {
	cout << this->height*this->width;
}
void Rectangle::printPerimeter() {
	cout << (this->height + this->width) * 2;
}


