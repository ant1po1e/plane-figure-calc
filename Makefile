compile:
	@mcs -out:./App.exe ./App.cs

run:
	@mono ./App.exe

.PHONY: compile run