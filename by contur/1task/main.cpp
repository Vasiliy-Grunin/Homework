#include "task1.h"
#include<iostream>
using namespace std;
int main()
{
	setlocale(LC_ALL, "rus");
	char gender;
	float height, width;
	cout << "please write your gender \n";
	cin >> gender;
	cout << "please write your height \n";
	cin >> height;
	cout << "please write your width \n";
	cin >> width;
	int tmp=getRecommendation(gender,height,width);
	switch (tmp)
	{
	case -1:
		cout << "похудеть";
		break;
	case 0:
		cout << "норма";
		break;
	case 1:
		cout << "пополнеть";
		break;
	default:
		cout << "error";
		break;
	}
	return 0;
}