using System;
class minmaxint {
static int Main() {
	Machep machep = new Machep();
	int maxintreal=int.MaxValue;
	int minintreal=int.MinValue;
	int i=1;
	while(i+1>i) {i++;}
	int j=1;
	while (j-1<j) {j++;}
	Console.WriteLine("my max int = {0}\n",i);
	Console.WriteLine($"actual max int is {maxintreal}");
	Console.WriteLine("my min int = {0}\n",j);
	Console.WriteLine($"actual min int is {minintreal}");
	Console.WriteLine($"Machine epsilon for a float is {machep.epvalfloat}");
	Console.WriteLine($"Machine epsilon for a double is {machep.epvaldouble}");
	Console.WriteLine($"Machine epsilon should be for a float {machep.epvalaprxfloat}");
	Console.WriteLine($"Machine epsilon should be for a double {machep.epvalaprxdouble}");
	return 0;
	}
}
