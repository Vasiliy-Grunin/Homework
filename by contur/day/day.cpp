#include <iostream>
using namespace  std;
int mig(short s, short m, short h) {
	s += 60 * m + h * 3600;
	return s;
}
int main()
{
	short s, m, h;//s-seconds,m-min,h-hours
	cout << "write seconds \n";
	cin >> s;
	cout << "write min \n";
	cin >> m;
	cout << "write hours \n";
	cin >> h;
	cout << "only seconds = " << mig(s, m, h) << endl;
}
