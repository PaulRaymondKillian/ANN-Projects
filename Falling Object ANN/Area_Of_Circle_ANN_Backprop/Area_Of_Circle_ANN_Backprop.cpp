/*------------------------------------------------------------------------
    Program :       Area of Circle Backprop ANN
    Written by:     Paul Killian
    Created:        2006-09-16
    Description:    Multi-Layer Network using Backprop
 -------------------------------------------------------------------------*/

#include <iostream>		// Include is like the package statement
#include <conio.h>		// Include Windows console IO header (non-Linux)
#include <math.h>
#include "Area_Of_Circle_ANN_Backprop.h"
#include <ctime>

using namespace std;	// Using statement is like Java's import statement


int main(int argc, char *argv[])	// Main - like in Java
{
	srand((unsigned)time(0));

	const int INPUT_WEIGHT = 0;	//Constant to mark the index for the input weight in the weight arrays
	const int BIAS_WEIGHT = 1;	//Constant to mark the index for the bias weight in the weight arrays

	double currentDiameter;		//Store current age of the rabbit for the current exemplar
	double rho = 0.1;	//Rho value for output node
	double rhoHidden = 0.2;	//Rho value for hidden layer nodes

	double totalError;
	double momentum[8][2] = {0};
	double outputMomentum[7] = {0};
	double tempOldWeight1 = 0;
	double tempOldWeight2 = 0;
	double tempOldOutputWeights[7] = {0};

	double sums[8];		//Array to store the sums for nodes 2-5 (using real indexing)
	double u[8];		//Array to store activiation values for nodes 2-5
	double fPrime[8];	//Array to store derivatives for nodes 2-5
	double delta[8];	//Array to store deltas for nodes 2-5

	double weightsHidden[7][2] = {
		{ 0, 0 },		// Unused weight index
		{0.1, -0.6},
		{-0.2, 0.5},
		{0.3, -0.4},
		{-0.4, 0.3},
		{0.5, -0.2},
		{-0.6, 0.1}
		};


	double weightsOutput[8] = {0 , -0.01, 0.02, -0.03, 0.04, -0.05, 0.06, -0.07};

	double exemplarSet[2][2] = {
		{1, 1},
		{2, 100}
		};


	// There are 45 Data Elements - so the array should be 0 to 44
	int randomizedIndexArray[5] = {
		0,1,2,3,4};


	//////////////////////////////////////////////////////////////////////////////
	//																			//
	//		End of Variable Declarations										//
	//		Begin Actual Coding Below											//
	//																			//
	//////////////////////////////////////////////////////////////////////////////

	int epoch = 1;

	while( epoch < 500000001 )
	{
		totalError = 0;

		/////////////////////////////////////////////////////////////////////
		// Randomize the Index so each epoch has a randomized exemplar order
		for( int i = 0; i < 2; i++ )
		{
			int tempIndexA = rand() % 2;
			int tempIndexB = rand() % 2;

			int tempA = randomizedIndexArray[ tempIndexA ];
			int tempB = randomizedIndexArray[ tempIndexB ];

			randomizedIndexArray[ tempIndexA ] = tempB;
			randomizedIndexArray[ tempIndexB ] = tempA;


		}//for


		for( int i = 0; i < 2; i++ )
		{
			currentDiameter = exemplarSet[ randomizedIndexArray[i] ][0];


////////////////
// Begin Node 1
////////////////
			sums[1] = calcSum( weightsHidden[ 1 ][ INPUT_WEIGHT ], currentDiameter, weightsHidden[ 1 ][ BIAS_WEIGHT ], 1 );
			u[1] = calcU( sums[1] );
			fPrime[1] = calcFPrime( u[1] );

			//cout << "Current Diameter: " << currentDiameter << endl
			//	<< "Node 1: "
			//	<< "Input Weight: " << weightsHidden[ 1 ][ INPUT_WEIGHT ] << " Bias Weight: " << weightsHidden[ 1 ][ BIAS_WEIGHT ] << endl
			//	<< "Sum[1]: " << sums[1] << " u[1]: " << u[1] << " fPrime[1]: " << fPrime[1] << endl << endl;


////////////////
// Begin Node 2
////////////////
			sums[2] = calcSum( weightsHidden[ 2 ][ INPUT_WEIGHT ], currentDiameter, weightsHidden[ 2 ][ BIAS_WEIGHT ], 1 );
			u[2] = calcU( sums[2] );
			fPrime[2] = calcFPrime( u[2] );

			//cout << "Current Diameter: " << currentDiameter << endl
			//	<< "Node 2: "
			//	<< "Input Weight: " << weightsHidden[ 2 ][ INPUT_WEIGHT ] << " Bias Weight: " << weightsHidden[ 2 ][ BIAS_WEIGHT ] << endl
			//	<< "Sum[2]: " << sums[2] << " u[2]: " << u[2] << " fPrime[2]: " << fPrime[2] << endl << endl;


////////////////
// Begin Node 3
////////////////
			sums[3] = calcSum( weightsHidden[ 3 ][ INPUT_WEIGHT ], currentDiameter, weightsHidden[ 3 ][ BIAS_WEIGHT ], 1 );
			u[3] = calcU( sums[3] );
			fPrime[3] = calcFPrime( u[3] );

			//cout << "Current Diameter: " << currentDiameter << endl
			//	<< "Node 3: "
			//	<< "Input Weight: " << weightsHidden[ 3 ][ INPUT_WEIGHT ] << " Bias Weight: " << weightsHidden[ 3 ][ BIAS_WEIGHT ] << endl
			//	<< "Sum[3]: " << sums[3] << " u[3]: " << u[3] << " fPrime[3]: " << fPrime[3] << endl << endl;



////////////////
// Begin Node 4
////////////////
			sums[4] = calcSum( weightsHidden[ 4 ][ INPUT_WEIGHT ], currentDiameter, weightsHidden[ 4 ][ BIAS_WEIGHT ], 1 );
			u[4] = calcU( sums[4] );
			fPrime[4] = calcFPrime( u[4] );

			//cout << "Current Diameter: " << currentDiameter << endl
			//	<< "Node 4: "
			// 	<< "Input Weight: " << weightsHidden[ 4 ][ INPUT_WEIGHT ] << " Bias Weight: " << weightsHidden[ 4 ][ BIAS_WEIGHT ] << endl
			//	<< "Sum[4]: " << sums[4] << " u[4]: " << u[4] << " fPrime[4]: " << fPrime[4] << endl << endl;


////////////////
// Begin Node 5
////////////////
			sums[5] = calcSum( weightsHidden[ 5 ][ INPUT_WEIGHT ], currentDiameter, weightsHidden[ 5 ][ BIAS_WEIGHT ], 1 );
			u[5] = calcU( sums[5] );
			fPrime[5] = calcFPrime( u[5] );
 
			//cout << "Current Diameter: " << currentDiameter << endl
			//	<< "Node 5: "
			//	<< "Input Weight: " << weightsHidden[ 5 ][ INPUT_WEIGHT ] << " Bias Weight: " << weightsHidden[ 5 ][ BIAS_WEIGHT ] << endl
			//	<< "Sum[5]: " << sums[5] << " u[5]: " << u[5] << " fPrime[5]: " << fPrime[5] << endl << endl;

////////////////
// Begin Node 6
////////////////
			sums[6] = calcSum( weightsHidden[ 6 ][ INPUT_WEIGHT ], currentDiameter, weightsHidden[ 6 ][ BIAS_WEIGHT ], 1 );
			u[6] = calcU( sums[6] );
			fPrime[6] = calcFPrime( u[6] );
 
			//cout << "Current Diameter: " << currentDiameter << endl
			//	<< "Node 6: "
			//	<< "Input Weight: " << weightsHidden[ 6 ][ INPUT_WEIGHT ] << " Bias Weight: " << weightsHidden[ 6 ][ BIAS_WEIGHT ] << endl
			//	<< "Sum[6]: " << sums[6] << " u[6]: " << u[6] << " fPrime[6]: " << fPrime[6] << endl << endl;




////////////////
// Begin Node 7 **Output**
////////////////
			sums[7] = calcSum( weightsOutput[1], u[1], weightsOutput[2], u[2], weightsOutput[3], u[3], weightsOutput[4], u[4], weightsOutput[5], u[5], weightsOutput[6], u[6], weightsOutput[7] );
			u[7] = sums[7];
			fPrime[7] = 1;

			//cout << "Node 7: (Output) " << endl <<
			//	"Sum[7]: " << sums[7] << " u[7]: " << u[7] << " fPrime[7]: " << fPrime[7] << endl << endl;





			///////////////////////////////////////////////////////////////////////
			//
			//		Calculate Deltas
			//
			//////////////////////////////////////////////////////////////////////

			delta[7] = calcDeltaOutput( exemplarSet[i][1], u[7] );
			delta[6] = calcDeltaHidden( weightsOutput[6], fPrime[6], delta[7] );
			delta[5] = calcDeltaHidden( weightsOutput[5], fPrime[5], delta[7] );
			delta[4] = calcDeltaHidden( weightsOutput[4], fPrime[4], delta[7] );
			delta[3] = calcDeltaHidden( weightsOutput[3], fPrime[3], delta[7] );
			delta[2] = calcDeltaHidden( weightsOutput[2], fPrime[2], delta[7] );
			delta[1] = calcDeltaHidden( weightsOutput[1], fPrime[1], delta[7] );

			//cout << endl << "Deltas: " << endl << "Delta 7: " << delta[7] << endl << "Delta6: " << delta[6] << endl << "Delta5: " << delta[5] << endl << "Delta4: " << delta[4] << endl << "Delta3: " << delta[3] << endl << "Delta2: " << delta[2] << endl << "Delta1: " << delta[1] << endl;


			/////////////////////////////////////////////////////////////////////
			//
			//		Calculate New Weights
			//
			/////////////////////////////////////////////////////////////////////


			// New Weights for Node 1
			weightsHidden[1][ BIAS_WEIGHT ] = calcNewWeight( weightsHidden[1][ BIAS_WEIGHT], rhoHidden, exemplarSet[i][0], delta[1], momentum[1][0] );
			weightsHidden[1][ INPUT_WEIGHT ] = calcNewWeight( weightsHidden[1][ INPUT_WEIGHT ], rhoHidden, exemplarSet[i][0], delta[1], momentum[1][1] );

			//momentum[1][0] =  calcMomentum( weightsHidden[1][ BIAS_WEIGHT ], tempOldWeight1 );
			//momentum[1][1] =  calcMomentum( weightsHidden[1][ INPUT_WEIGHT ], tempOldWeight2 );

			//tempOldWeight1 = weightsHidden[2][ BIAS_WEIGHT ];
			//tempOldWeight2 = weightsHidden[2][ INPUT_WEIGHT ];

			// New Weights for Node 2
			weightsHidden[2][ BIAS_WEIGHT ] = calcNewWeight( weightsHidden[2][ BIAS_WEIGHT], rhoHidden, exemplarSet[i][0], delta[2], momentum[2][0] );
			weightsHidden[2][ INPUT_WEIGHT ] = calcNewWeight( weightsHidden[2][ INPUT_WEIGHT ], rhoHidden, exemplarSet[i][0], delta[2], momentum[2][1] );

			//momentum[4][0] =  calcMomentum( weightsHidden[2][ BIAS_WEIGHT ], tempOldWeight1 );
			//momentum[4][1] =  calcMomentum( weightsHidden[2][ INPUT_WEIGHT ], tempOldWeight2 );

			//tempOldWeight1 = weightsHidden[3][ BIAS_WEIGHT ];
			//tempOldWeight2 = weightsHidden[3][ INPUT_WEIGHT ];

			// New Weights for Node 3
			weightsHidden[3][ BIAS_WEIGHT ] = calcNewWeight( weightsHidden[3][ BIAS_WEIGHT], rhoHidden, exemplarSet[i][0], delta[3], momentum[3][0] );
			weightsHidden[3][ INPUT_WEIGHT ] = calcNewWeight( weightsHidden[3][ INPUT_WEIGHT ], rhoHidden, exemplarSet[i][0], delta[3], momentum[3][1] );

			//momentum[5][0] =  calcMomentum( weightsHidden[3][ BIAS_WEIGHT ], tempOldWeight1 );
			//momentum[5][1] =  calcMomentum( weightsHidden[3][ INPUT_WEIGHT ], tempOldWeight2 );

			//tempOldWeight1 = weightsHidden[4][ BIAS_WEIGHT ];
			//tempOldWeight2 = weightsHidden[4][ INPUT_WEIGHT ];

			// New Weights for Node 4
			weightsHidden[4][ BIAS_WEIGHT ] = calcNewWeight( weightsHidden[4][ BIAS_WEIGHT], rhoHidden, exemplarSet[i][0], delta[4], momentum[4][0] );
			weightsHidden[4][ INPUT_WEIGHT ] = calcNewWeight( weightsHidden[4][ INPUT_WEIGHT ], rhoHidden, exemplarSet[i][0], delta[4], momentum[4][1] );

			//momentum[6][0] =  calcMomentum( weightsHidden[4][ BIAS_WEIGHT ], tempOldWeight1 );
			//momentum[6][1] =  calcMomentum( weightsHidden[4][ INPUT_WEIGHT ], tempOldWeight2 );

			//tempOldWeight1 = weightsHidden[5][ BIAS_WEIGHT ];
			//tempOldWeight2 = weightsHidden[5][ INPUT_WEIGHT ];

			// New Weights for Node 5
			weightsHidden[5][ BIAS_WEIGHT ] = calcNewWeight( weightsHidden[5][ BIAS_WEIGHT], rhoHidden, exemplarSet[i][0], delta[5], momentum[5][0] );
			weightsHidden[5][ INPUT_WEIGHT ] = calcNewWeight( weightsHidden[5][ INPUT_WEIGHT ], rhoHidden, exemplarSet[i][0], delta[5], momentum[5][1] );

			//momentum[7][0] =  calcMomentum( weightsHidden[5][ BIAS_WEIGHT ], tempOldWeight1 );
			//momentum[7][1] =  calcMomentum( weightsHidden[5][ INPUT_WEIGHT ], tempOldWeight2 );

			//tempOldWeight1 = weightsHidden[6][ BIAS_WEIGHT ];
			//tempOldWeight2 = weightsHidden[6][ INPUT_WEIGHT ];

			// New Weights for Node 6
			weightsHidden[6][ BIAS_WEIGHT ] = calcNewWeight( weightsHidden[6][ BIAS_WEIGHT], rhoHidden, exemplarSet[i][0], delta[6], momentum[6][0] );
			weightsHidden[6][ INPUT_WEIGHT ] = calcNewWeight( weightsHidden[6][ INPUT_WEIGHT ], rhoHidden, exemplarSet[i][0], delta[6], momentum[6][1] );

			//momentum[7][0] =  calcMomentum( weightsHidden[5][ BIAS_WEIGHT ], tempOldWeight1 );
			//momentum[7][1] =  calcMomentum( weightsHidden[5][ INPUT_WEIGHT ], tempOldWeight2 );


			//tempOldOutputWeights[0] = weightsOutput[0];
			//tempOldOutputWeights[1] = weightsOutput[1];
			//tempOldOutputWeights[2] = weightsOutput[2];
			//tempOldOutputWeights[3] = weightsOutput[3];
			//tempOldOutputWeights[4] = weightsOutput[4];
			//tempOldOutputWeights[5] = weightsOutput[5];
			//tempOldOutputWeights[6] = weightsOutput[6];


			// New Weights for Output Node
			weightsOutput[0] = calcNewWeight( weightsOutput[0], rho, u[7], delta[7], outputMomentum[0] );
			weightsOutput[1] = calcNewWeight( weightsOutput[1], rho, u[6], delta[7], outputMomentum[1] );
			weightsOutput[2] = calcNewWeight( weightsOutput[2], rho, u[5], delta[7], outputMomentum[2] );
			weightsOutput[3] = calcNewWeight( weightsOutput[3], rho, u[4], delta[7], outputMomentum[3] );
			weightsOutput[4] = calcNewWeight( weightsOutput[4], rho, u[3], delta[7], outputMomentum[4] );
			weightsOutput[5] = calcNewWeight( weightsOutput[5], rho, u[2], delta[7], outputMomentum[5] );
			weightsOutput[6] = calcNewWeight( weightsOutput[6], rho, u[1], delta[7], outputMomentum[6] );

			//outputMomentum[0] = calcMomentum( weightsOutput[0], tempOldOutputWeights[0] );
			//outputMomentum[1] = calcMomentum( weightsOutput[1], tempOldOutputWeights[1] );
			//outputMomentum[2] = calcMomentum( weightsOutput[2], tempOldOutputWeights[2] );
			//outputMomentum[3] = calcMomentum( weightsOutput[3], tempOldOutputWeights[3] );
			//outputMomentum[4] = calcMomentum( weightsOutput[4], tempOldOutputWeights[4] );
			//outputMomentum[5] = calcMomentum( weightsOutput[5], tempOldOutputWeights[5] );
			//outputMomentum[6] = calcMomentum( weightsOutput[6], tempOldOutputWeights[6] );


			//cout << endl << "Node 1 Bias Weight: " << weightsHidden[1][ BIAS_WEIGHT ] << " Node 1 Input Weight " << weightsHidden[1][ INPUT_WEIGHT ] << endl;
			//cout << endl << "Node 2 Bias Weight: " << weightsHidden[2][ BIAS_WEIGHT ] << " Node 2 Input Weight " << weightsHidden[2][ INPUT_WEIGHT ] << endl;
			//cout << endl << "Node 3 Bias Weight: " << weightsHidden[3][ BIAS_WEIGHT ] << " Node 3 Input Weight " << weightsHidden[3][ INPUT_WEIGHT ] << endl;
			//cout << endl << "Node 4 Bias Weight: " << weightsHidden[4][ BIAS_WEIGHT ] << " Node 4 Input Weight " << weightsHidden[4][ INPUT_WEIGHT ] << endl;
			//cout << endl << "Node 5 Bias Weight: " << weightsHidden[5][ BIAS_WEIGHT ] << " Node 5 Input Weight " << weightsHidden[5][ INPUT_WEIGHT ] << endl;
			//cout << endl << "Node 6 Bias Weight: " << weightsHidden[6][ BIAS_WEIGHT ] << " Node 6 Input Weight " << weightsHidden[6][ INPUT_WEIGHT ] << endl;
			//cout << endl << "Node 7-1 Weight: " << weightsOutput[1] << " Node 7-2 Weight: " << weightsOutput[2] << " Node 7-3 Weight: " << weightsOutput[3] << " Node 7-4 Weight: " << weightsOutput[4] << " Node 7-5 Weight: " << weightsOutput[5] << " Node 7-6 Weight: " << weightsOutput[6] << endl;

		if(  ( epoch % 5000000 ) == 0)
		{
			cout << endl << "Correct Area: " << exemplarSet[i][1] << "	" << "Actual Network Output: " << u[7] << endl;
			cout << "Error: " << pow(( exemplarSet[i][1] - u[7] ), 2) << "	RhoHidden: " << rhoHidden << "	RhoOutput: " << rho << endl<< "Epoch: " << epoch << endl << "--------------------------------------------" << endl << endl;

				int pause;
				cin >> pause;
		}	

			//totalError += pow(( exemplarSet[i][1] - u[7] ), 2);
			totalError = exemplarSet[i][1] - u[7];
		}//for()

	epoch++;

		if( ( epoch % 1 ) == 0 )
		{
			rhoHidden = rhoHidden * 0.99;
			rho = rho * 0.99;
		

		
			//cout << "Epoch: " << epoch << "	totalError: " << totalError << "	avgError: " << totalError/2 << " " << currentDiameter << " " << u[7] << " " << rho << endl;
		}

		cout << u[7] << endl;

		if( epoch == 100 )
			cin >> epoch;

	}//while

    return 0;
}



	//////////////////////////////////////////////////////////////////////////////
	//		Weighted sum of node
	double calcSum( double inputWeight, double input, double biasWeight, double bias )
	{
		return ((inputWeight * input) + (biasWeight * bias));

	}//calcSum for hidden layer nodes


	//////////////////////////////////////////////////////////////////////////////
	//		Weighted sum of node (Overloaded)
	double calcSum( double inputWeightA, double inputA, double inputWeightB, double inputB, double inputWeightC, double inputC, double inputWeightD, double inputD,  double inputWeightE, double inputE, double inputWeightF, double inputF, double weightBias )
	{
		return ((inputWeightA * inputA ) + (inputWeightB * inputB) + (inputWeightC * inputC) + (inputWeightD * inputD) + (inputWeightE * inputE) + (inputWeightF * inputF) + weightBias );

	}//calcSum for output node


	//////////////////////////////////////////////////////////////////////////////
	//		Calculate activation function
	double calcU( double sum )
	{
		return (1 / ( 1 + ( pow( 2.718281828, -sum ))));
		//return ( 0.5 * (1 + tanh(sum)));


	}//calcU


	/////////////////////////////////////////////////////////////////////////////
	//		Calculate F Prime
	double calcFPrime( double u )
	{
		return ( u * ( 1 - u ) );
		//return ( ( log( pow(2.718281828, 2 * u ) + 1 ) ) / 2 );
		//return ( 1 - pow( u, 2) );

	}//fPrime()


	double calcDeltaOutput( double correctLensWeight, double outputU )
	{
		return (( correctLensWeight - outputU ) );

	}//calcDeltaOutput

	double calcDeltaHidden( double nodeWeight, double nodeFPrime, double outputDelta )
	{
		return ( nodeWeight * nodeFPrime * outputDelta );

	}//calcDeltaHidden

	double calcNewWeight( double oldWeight, double currentRho, double currentU, double currentDelta, double momentum )
	{
		return ( oldWeight + ( currentRho * currentU * currentDelta ) + ( 0.5 * momentum ) );

	}//calcNewWeight

	double calcMomentum( double newWeight, double oldWeight )
	{
		//return ( newWeight - oldWeight );
		return 0;

	}//calcMomentum

	double calcSimAnnealing( double oldWeight, int epoch )
	{
		double temp1;

		temp1 = ( ( rand() % 15 ) / 100 ) * oldWeight;

		if( ( rand() % 100 ) < 50 )
			temp1 = -temp1;

		return temp1;

	}


