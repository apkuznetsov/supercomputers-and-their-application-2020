// lab2.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <stdio.h>
#include <math.h>
#include <conio.h>
#include <windows.h>
#include <time.h>
#include <cstdlib>
#include <iomanip>
#pragma intrinsic(__rdtsc)
#define _USE_MATH_DEFINES

using namespace std;

double generate_a() {
	const double MIN = -3.14;
	const double MAX = 3.14;

	return  (double)rand() / (double)RAND_MAX * (MAX - MIN);
}

void calc_expressions() {
	double a = generate_a();
	double x = rand() % 100;
	double y = rand() % 100;

	double t1 = sin(a) * x + cos(a) * y;
	double t2 = -cos(a) * x + sin(a) * y;
}

int main()
{
	const int REPEAT_TIMES = 10000000;

	const double MY_PROCESSOR_CLOCKS_PER_SEC = 1800000000;
	unsigned __int64 time1;
	unsigned __int64 time2;

	time1 = __rdtsc();

	for (int i = 0; i < REPEAT_TIMES; i++)
		calc_expressions();

	time2 = __rdtsc();

	double time = (time2 - time1) / MY_PROCESSOR_CLOCKS_PER_SEC;
	cout << "time = " << time << endl;
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
