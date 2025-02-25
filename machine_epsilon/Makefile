Out.txt :maxminint.exe
	mono maxminint.exe > Out.txt
maxminint.exe : maxminint.cs machep.dll
	mcs -target:exe -out:maxminint.exe maxminint.cs machep.cs -reference:machep.dll
machep.dll: machep.cs
	mcs -target:library -out:machep.dll machep.cs
clean:                           
	rm -f Out.txt maxminint.exe  # remove secondary files





