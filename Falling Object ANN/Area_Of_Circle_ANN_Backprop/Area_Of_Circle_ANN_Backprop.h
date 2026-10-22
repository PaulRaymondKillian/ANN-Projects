/*------------------------------------------------------------------------
    Program :           Program01.h
    Written by:         Paul Killian
    Created:            2006-01-25
    Description:        Header File For Elementary Multiplication Program
 -------------------------------------------------------------------------*/

#ifndef AREA_OF_CIRCLE_ANN_BACKPROP_H
#define AREA_OF_CIRCLE_ANN_BACKPROP_H

#include <conio.h>
#include <iostream>

using namespace std;

double calcSum( double inputWeight, double input, double biasWeight, double bias );

double calcSum( double inputWeightA, double inputA, double inputWeightB, double inputB, double inputWeightC, double inputC, double inputWeightD, double inputD, double inputWeightE, double inputE, double inputWeightF, double inputF, double weightBias );

double calcU( double sum );

double calcFPrime( double u );

double calcDeltaOutput( double correctLensWeight, double outputU );

double calcDeltaHidden( double nodeWeight, double nodeFPrime, double outputDelta );

double calcNewWeight( double oldWeight, double currentRho, double currentU, double currentDelta, double momentum );

double calcMomentum( double newWeight, double oldWeight );

#endif