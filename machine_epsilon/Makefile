Out.txt :maxminint.exe              # Out.txt depends on funcvals.exe
	mono maxminint.exe > Out.txt # run maxminint.exe, send output to Out.txt
maxminint.exe : maxminint.cs             # maxminint.exe depends on mathexercise.cs
	mcs -target:exe -out:maxminint.exe maxminint.cs # compile mathexercise.cs, save bytecode in funcvals.exe
clean:                           # a phoney target, no dependencies
	rm -f Out.txt maxminint.exe  # remove secondary files





