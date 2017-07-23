csc /target:library /out:Calc.dll SimpleCalc.cs ComplexCalc.cs
csc /target:exe /out:MyCalc.exe /reference:Calc.dll Calc.cs
MyCalc.exe