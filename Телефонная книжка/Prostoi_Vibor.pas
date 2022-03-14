﻿Program Prostoi_Vibor;
const n=100000;
type omas=array [1..n] of integer;
var a: omas;

Procedure init(var a:omas);
var i:integer;
begin
for i:=1 to n do
 //A[i]:=random(100);
 A[i]:=i;
 //A[i]:=n-i;
end;

Procedure print(a:omas);
var i:integer;
begin
writeln('наш массив:');
for i:=1 to n do
 write(A[i],' ');
writeln();
end;

Procedure Sortirovka(var a:omas);
var i,j,min,ind:integer; sravneniya,perestanovki:int64;
begin
sravneniya:=0;
perestanovki:=0;
 for i:=1 to n-1 do
  begin
   min:=a[i]; 
   ind:=i;
   for j:=i+1 to n do
    begin
     inc(sravneniya);
     if a[j]<=min then
     begin
       min:=a[j];
       ind:=j;
     end;
    end;
   if i<>ind then inc(perestanovki);
   a[ind]:=a[i];
   a[i]:=min;
  end;
 writeln('сравнений произошло:',sravneniya);
 writeln('перестановок произошло:',perestanovki);
end;

BEGIN
init(a);
//print(a);
Sortirovka(a);
writeln('изменённый массив');
//print(a);
END.