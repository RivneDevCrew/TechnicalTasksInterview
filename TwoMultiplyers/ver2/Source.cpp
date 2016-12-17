#include <iostream>
#include <cmath>

using namespace std;

int get_times(int a)
{
	int i;
	int div = (int)sqrt(a);
	int times = 0;
	for(i = 1; i <= div; i++)
	{
		if((a % i) == 0)
		{
			times++;
		}
	}
	return times;
}

void main()
{
	int input = 0;

	cin >> input; // read input
	int i = 2;

	int t = 0;

	while(t != input)
	{
		t = get_times(i);
		i++;
	}
	i--;
	cout << i << endl;
}