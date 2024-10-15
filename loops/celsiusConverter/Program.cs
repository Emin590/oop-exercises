double degreeC = -5;
string degreeSign = "\u00B0";

for (double i = -5; i <= 40; i+=0.5) {
	double degreeF = 32 + (9/5 * i);
	Console.WriteLine(i + degreeSign + "C is equal to " +  degreeF + degreeSign + "F");
}


