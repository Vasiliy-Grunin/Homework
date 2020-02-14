#include <iostream>
#include<vector>
#include<string>
using namespace std;
int vactor(int n){
	vector<int> arr;
	for (int i = 0; i < 200000000; i++) {
		n = rand() % 101 - 100;
		arr.push_back(n);
	}
	for (int i = 0; i < 200000000; i++) {
		cout << arr[i];
	}//were long
	return 0;
}
int main()
{
	/*int n;
	double x;
	cout << "enter n \n";
	cin >> n;
	x = n > 0 ? 5.4 : vactor(n);//n>0 условие, 5.4 условие верно.3.2 ложь
	cout << "x= " << x << endl;*/
	string str;
	string nstr;
	cin>>str;
	int tmp = 0,size= str.length();
	for (int i = 0; i < size+2; i++)
	{				
		if (str[i] == str[i + 1])
			tmp++;
		else if (str[i+1] == '\0') {
			nstr += str[i];
			switch (tmp)
			{
			case 1:
				nstr = nstr + '1';
				break;
			case 2:
				nstr = nstr + '2';
				break;
			case 3:
				nstr = nstr + '3';
				break;
			case 4:
				nstr = nstr + '4';
				break;
			case 5:
				nstr = nstr + '5';
				break;
			case 6:
				nstr = nstr + '6';
				break;
			case 7:
				nstr = nstr + '7';
				break;
			case 8:
				nstr = nstr + '8';
				break;
			case 9:
				nstr = nstr + '9';
				break;
			default:
				break;
			}
			tmp = 0;
			break;
		}
		else
		{
			nstr += str[i];
			switch (tmp)
			{
			case 1:
				nstr = nstr + '1';
				break;
			case 2:
				nstr = nstr + '2';
				break;
			case 3:
				nstr = nstr + '3';
				break;
			case 4:
				nstr = nstr + '4';
				break;
			case 5:
				nstr = nstr + '5';
				break;
			case 6:
				nstr = nstr + '6';
				break;
			case 7:
				nstr = nstr + '7';
				break;
			case 8:
				nstr = nstr + '8';
				break;
			case 9:
				nstr = nstr + '9';
				break;
			default:
				break;
			}
			tmp = 0;
		}
	}
	cout << nstr;
	//Console.WriteLine(tmp);
	return 0;
}
