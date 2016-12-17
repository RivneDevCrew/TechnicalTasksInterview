#include <iostream>
#include <vector>
#include <map>
#include <time.h>
#include <fstream>
using namespace std;
typedef pair<int, int> MyPair;
bool inFile(map<_int64, int> inputMap)
{
		ofstream fout("resultFile.txt"); 
		fout << "Result File starts here..." << endl;
		map<_int64, int >::iterator itCur = inputMap.begin();
		map<_int64, int >::const_iterator itEnd = inputMap.end(); // set iterators for map so we can use inputMap
		while( itCur != itEnd )
		{
			fout << "Digit -  " << itCur->first << " :: Count of ways - " << itCur->second << endl; // write in file "Digit - x :: Count of ways - y"
			++itCur;
		}
		cout << "In!" << endl;
		fout << "Result File finishes here..." << endl;
		fout.close(); // tell user that its finished and close file output stream
		return true;
}
void showMapInFile(map<_int64, int> inputMap)
{
		map<_int64, int >::iterator itCur = inputMap.begin();
		map<_int64, int >::const_iterator itEnd = inputMap.end();
		while( itCur != itEnd )
		{
			cout << "Digit -  " << itCur->first << " :: Count of ways - " << itCur->second << endl;
			++itCur;
		} // write in console 
		inFile(inputMap);
}

int Result(int K)
{
		_int64 res = 1;
		vector<int> dividers; 
		map<_int64, int> resultsMap; // digit, count of ways
		float t = clock(); // get current time so we can know time of compile of search part of program

		while (true) // endless loop
		{
			dividers.clear();

			for(int i = 1; i <= res / 2; ++i)
			{
				if(res % i == 0) 
				{
					dividers.push_back(i); // get dividers
				}
			}
			dividers.push_back(res);

			resultsMap.insert(MyPair(res, (dividers.size() + 1) / 2)); // count of ways = (dividers.size() + 1) / 2
		

			if((dividers.size() + 1) / 2  == K)
			{
				t = ((clock() - t) ) ; // stop timer 
				showMapInFile(resultsMap);
				cout << "time :  " << (float)t/CLOCKS_PER_SEC << "sec"<< endl;
				return res; // exit from while(true)
			}
			res++;
		}
}


void main()
{
		int k;
		//cout << (int)sqrt(5); 
		cout << "Enter K: ";
		cin >> k;
		int N = Result(k);
		cout << endl << "Result: " << N << endl;
}




