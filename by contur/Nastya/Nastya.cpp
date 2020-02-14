#include <iostream>
#include<string>
#include<algorithm>
#include<sstream>
#include<stdlib.h>
#include<math.h>
using namespace std;
double funct(char type, string buf, double answer) {
	answer = atof(buf.c_str());//перевод строки, можно пройтись в цикле и присваивать каждому элемениу массива опр цифру
	switch (type)//то же можно сделать и через if
	{
		case 'R': {
			answer = (answer*3.14)/180;
	    }
				  break;
		case 'r':{
			answer = (answer * 3.14) / 180;
   	    }
				 break;
		case 'D': {
			answer = (answer * 180) / 3.14;
		}
				  break;
		case 'd': {
			answer = (answer * 180) / 3.14;
		}
				  break;
		default:
			return 0;
			break;
	}
	return answer;
}
int main()
{
	string buf;
	char type;
	double answer=0;
	cin >> buf;
	for (const auto& b : buf) {
		if (b=='D'||b=='d'||b=='R'||b=='r')
		{
			type = b;
		}
	}
	buf.pop_back();
	cout << funct(type,buf,answer);
}
