#include <iostream>
#include<cmath>
using namespace std;
int main()
{
	const double g = 9.8;
	const double pi = 3.1415;
	double v, alpha,T;
	double t, x, y;
	cout << "enter speed v= \n";
	cin >> v;
	cout << "enter angel alpha= \n";
	cin >> alpha;
	alpha *= pi / 180;
	T = 2 * v * sin(alpha) / g;
	cout << "enter time t= \n";
	cin >> t;
	x = v * t * cos(alpha);
	y = v * t * sin(alpha) - g * t * t / 2;
	cout << "x = " << x << endl;
	cout << "y = " << y << endl;
	return 0;
}
