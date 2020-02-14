#include <iostream>
using namespace std;

int getRecommendation(char gender, float height, float weight)
{
	switch (gender)
	{
	case 'm': {
		if( height - 100 > weight )
		return 1;
		if( height - 100 == weight )
		return 0;
		if ( height - 100 < weight )
		return -1;
	}
	case 'w': {
		if (height - 110 > weight)
			return 1;
		if (height - 110 == weight)
			return 0;
		if (height - 110 < weight)
			return -1;
	}
	default:
		cout << "error";
		break;
	}
}