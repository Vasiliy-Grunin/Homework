#include <iostream>
#include<conio.h>//for Input
using namespace std;
bool gameover;
const int width = 40;
const int height = 20;
int x, y, fruitx, fruity,score;
int talix[100], taliy[100];
int nTall=0;
enum eDirection{ STOP = 0,LEFT,RIGHT,UP,DOWN};
eDirection dir;
void Setup() {
	gameover = false;
	dir = STOP;
	x = width / 2 - 1;
	y = height / 2 - 1;
	fruitx = rand() % width;
	fruity = rand() % height;
	score = 0;
}
void Input() {
	if (_kbhit()) {//autonomic input
		switch (_getch())//what symbol
		{
			case 'a':
				dir = LEFT;
				break;
			case 's':
				dir = DOWN;
				break;
			case 'd':
				dir = RIGHT;
				break;
			case 'w':
				dir = UP;
				break;
			case 'x':
				gameover == true;
				break;
		}
	}
}
void Draw() {
	system("cls");//clear cmd
	for (int i = 0; i < width + 1; i++)
		cout << "#";
	cout << endl;
	for (int i = 0; i < height; i++) {
		for (int j = 0; j < width; j++)
		{
			if(j==0 || j==width-1)
				cout << "#";
			if (i == y && j == x)
				cout << "S";
			else if (i == fruity && j == fruitx)
				cout << "*";
			else {
				bool print = false;
				for (int k = 0; k < nTall;k++ ) {
					if (talix[k] == j && taliy[k] == i) {
						print = true;
						cout << "o";
					}
				}
				if(!print)
					cout << " ";
			}
		}
		cout << endl;
	}
	for (int i = 0; i < width + 1; i++)
		cout << "#";
	cout << endl;
	cout << "Score: " << score;
}
void Logic() {
	int prevX=talix[0];
	int prevY = taliy[0];
	int prev2x, prev2y;
	talix[0] = x;
	taliy[0] = y;
	for (int i = 1; i < nTall; i++) {
		prev2x = talix[i]; 
		prev2y = taliy[i];
		talix[i] = prevX;
		taliy[i] = prevY;
		prevX = prev2x;
		prevY = prev2y;
	}
	switch (dir)
	{
	case LEFT:
		x--;
		break;
	case RIGHT:
		x++;
		break;
	case UP:
		y--;
		break;
	case DOWN:
		y++;
		break;
	}
	//if (x > width || x<=0 || y>height || y < 0)
		//gameover = true;
	if (x >width )
		x = 0;
	else if(x <0) 
		x = width-2;


	if (y > height)
		y = 0;
	else if (x < 0)
		y = height - 2;
	for (int i = 0; i < nTall; i++) {
		if (talix[i] == x && taliy[i] == y)
			gameover = true;
	}
	if (x == fruitx && y == fruity) {
		score++;
		fruitx = rand() % width;
		fruity = rand() % height;
		nTall++;
	}
}
int main()
{
	Setup();
	while (!gameover)
	{
		Draw();
		Logic();
		Input();
	}
}

