double secSince1970 = 33436800;
double secToYears = secSince1970 / (60 * 60 * 24 * 365);
double secsLeft = secSince1970 % (60 * 60 * 24 * 365);
double daysLeft = secsLeft / (60 * 60 * 24);

Console.WriteLine(Math.Floor(secToYears) + " " + Math.Floor(daysLeft));
