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

int test_dynamic_float() {
	const int ARR_SIZE = 40000;

	const double MY_PROCESSOR_CLOCKS_PER_SEC = 1800000000;
	unsigned __int64 time1 = 0;
	unsigned __int64 time2 = 0;

	float* a = new float[ARR_SIZE];
	float* b = new float[ARR_SIZE];
	float* c = new float[ARR_SIZE];

	for (int i = 0; i < ARR_SIZE; i++)
		a[i] = static_cast <float> (rand()) / static_cast <float> (RAND_MAX);

	for (int i = 0; i < ARR_SIZE; i++)
		b[i] = static_cast <float> (rand()) / static_cast <float> (RAND_MAX);

	time1 = __rdtsc();

	for (int i = 0; i < ARR_SIZE; i++)
		c[i] = a[i] + b[i];

	time2 = __rdtsc();

	double time = (time2 - time1) / MY_PROCESSOR_CLOCKS_PER_SEC;
	cout << time << endl;

	delete[] a;
	delete[] b;
	delete[] c;

	return 0;
}
