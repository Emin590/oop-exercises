//i assume there is 30 days a month meaning 360 days a year meaning 354th day is xmas

double secSinceNewYear = 60 * 60 * 24 * 310; //i just find how many secs 27.5 days is
double secToMonths = (secSinceNewYear / (60 * 60 * 24 * 30)) + 1;
double secsLeft = secSinceNewYear % (60 * 60 * 24 * 30);
double daysLeft = secsLeft / (60 * 60 * 24);

Console.WriteLine("Month and day of the year: " + Math.Floor(secToMonths) + " " + Math.Floor(daysLeft));

if (Math.Floor(secToMonths) == 12 && Math.Floor(daysLeft) == 24) {
	Console.WriteLine("Its Xmas");
}

double secTillXmas = (60 * 60 * 24 * 354) - secSinceNewYear;
double monthTillXmas = (secTillXmas / (60 * 60 * 24 * 30));
double secLeftTillXmas = secTillXmas % (60 * 60 * 24 * 30);
double daysLeftTillXmas = secLeftTillXmas / (60 * 60 * 24);

Console.WriteLine("Months and days until Xmas: " + Math.Floor(monthTillXmas) + " " + Math.Floor(daysLeftTillXmas));