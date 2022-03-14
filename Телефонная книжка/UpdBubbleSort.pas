Program UpdBubble_Sort;
const n=100000;
type omas=array [1..n] of integer;
var a: omas;

Procedure init(var a:omas);
var i:integer;
begin
for i:=1 to n do
 A[i]:=random(100);
 //A[i]:=i;
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
var i,j,c,f:integer; sravneniya,perestanovki:int64;
begin
i:=1;
j:=1;
f:=0;
sravneniya:=0;
perestanovki:=0;
while i<n do
 begin
  f:=0;
  j:=1;
  while j<n do
   begin
    inc(sravneniya);
    if A[j]>=A[j+1] then begin inc(perestanovki); c:=A[j]; A[j]:=A[j+1]; A[j+1]:=c; f:=1; end;
    inc(j);
   end;
  if f=0 then i:=n+5;
  inc(i);
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