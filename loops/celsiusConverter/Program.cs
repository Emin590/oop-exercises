double degreeC = -5;
string degreeSign = "\u00B0";

do {
	double degreeF = 32 + (9/5 * degreeC);
	Console.WriteLine(degreeC + degreeSign + "C is equal to " +  degreeF + degreeSign + "F");
	degreeC += 0.5;
} while (degreeC <= 40);

