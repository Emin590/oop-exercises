//i assume there is 30 days a month meaning 360 days a year meaning 354th day is xmas
double price = 599.95;
double secSinceNewYear = 60 * 60 * 24 * 356; //i just find how many secs last number in code is in days
double secToMonths = (secSinceNewYear / (60 * 60 * 24 * 30)) + 1;
double secsLeft = secSinceNewYear % (60 * 60 * 24 * 30);
double daysLeft = secsLeft / (60 * 60 * 24);

Console.WriteLine("Month and day of the year: " + Math.Floor(secToMonths) + " " + Math.Floor(daysLeft));

if (Math.Floor(secToMonths) == 12 && (Math.Floor(daysLeft) >= 24 && Math.Floor(daysLeft) <= 26)) {
	price = price * 0.7;
}

Console.WriteLine("Price is: " + Math.Round(price) + "DKK");
