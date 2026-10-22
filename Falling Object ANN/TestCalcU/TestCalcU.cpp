/*------------------------------------------------------------------------
    Program :       Area of Circle Backprop ANN
    Written by:     Paul Killian
    Created:        2006-09-16
    Description:    Multi-Layer Network using Backprop
 -------------------------------------------------------------------------*/

#include <iostream>		// Include is like the package statement
#include <conio.h>		// Include Windows console IO header (non-Linux)
#include <math.h>
#include "TestCalcU.h"

using namespace std;	// Using statement is like Java's import statement


int main(int argc, char *argv[])	// Main - like in Java
{

	double input = 0;

	while( input != 1337 )
	{
		cin >> input;

		cout << "calcU(" << input << "): " << calcU( input ) << endl;
		cout << (1/2)(1 + tanh(input)) << " " << tanh(input) << " " << 1 + tanh(input) << " " << (0.5)*(1+tanh(input)) << endl;

	}//while

    return 0;
}


	//////////////////////////////////////////////////////////////////////////////
	//		Calculate activation function
	double calcU( double sum )
	{
		//return (1 / ( 1 + ( pow( 2.718281828, -sum ))));
		return (1/2)(1 + tanh(sum));


	}//calcU

