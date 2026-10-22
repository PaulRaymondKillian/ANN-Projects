/*------------------------------------------------------------------------
    Program :       SOURCE - Artificial Neural Network Backpropagation
    Written by:     Paul Killian
    Created:        2008-1-14
    Description:    Multi-Layer Network using Backprop
 -------------------------------------------------------------------------*/

#include <iostream>		// Include is like the package statement
#include <conio.h>		// Include Windows console IO header (non-Linux)
#include <math.h>
#include <time.h>

using namespace std;	// Using statement is like Java's import statement

void randomizeTheIndexArray( void );

	//////////////////////////////
	// Begin Constants			//
	//////////////////////////////
	const int INPUT_WEIGHT = 0;
	const int BIAS_WEIGHT = 0;

	//////////////////////////////
	// Begin Declarations		//
	//////////////////////////////
	double exemplarSet[30][2] = {
		{0, 0},
		{0, 0}
		};

	double validationSet[2][2] = {
		{0, 0},
		{0, 0}
		};

	double hiddenLayerWeights[7][2] = {
		{0, 0},
		{0, 0}
		};

	double outputLayerWeighs[8] = { 0 };

	int randomizedIndexArray[30] = {
		0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29};


int main(int argc, char *argv[])	// Begin Main
{
	randomizeTheIndexArray();

	int a = 1;
	while( cin >> a != 0 )
	{
		for(int x = 0; x < 30; x++)
			//cout << randomizedIndexArray[x] << ",";
		cout << endl;
	}
}

void randomizeTheIndexArray( void )
{
	srand((int)time);
	/////////////////////////////////////////////////////////////////////
	// Randomize the Index so each epoch has a randomized exemplar order
	for( int i = 0; i < 30; i++ )
	{
		int tempIndexA = rand() % 30;
		int tempIndexB = rand() % 30;

		int tempA = randomizedIndexArray[ tempIndexA ];
		int tempB = randomizedIndexArray[ tempIndexB ];

		randomizedIndexArray[ tempIndexA ] = tempB;
		randomizedIndexArray[ tempIndexB ] = tempA;


	}//for
}

