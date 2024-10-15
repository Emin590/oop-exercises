double degreeC = 40;
string degreeSign = "\u00B0";

while (degreeC >= -5) {
	
	double degreeF = 32 + (9/5 * degreeC);
	Console.WriteLine(degreeC + degreeSign + "C is equal to " +  degreeF + degreeSign + "F");
	degreeC -= 0.5;

}


