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
	return  (double)rand() / (double)RAND_MAX * (6.28);
}

double generate_x() {
	return rand() % 100;
}

void calc_expressions() {
	double a = generate_a();
	double x = generate_x();
	double y = generate_x();

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