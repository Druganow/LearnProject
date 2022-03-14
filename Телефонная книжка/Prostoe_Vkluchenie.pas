Program Prostoe_Vkluchenie;
const n=100000;
type omas=array [1..n] of integer;
var a: omas;

Procedure init(var a:omas);
var i:integer;
begin
for i:=1 to n do
 //A[i]:=random(100);
 //A[i]:=i;
 A[i]:=n-i;
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
var i,j,c:integer; sravneniya,perestanovki:int64;
begin
sravneniya:=0;
perestanovki:=0;
 for i:=2 to n do
  begin
   c:=A[i];
   j:=i;
   if A[j-1]<=c then inc(sravneniya);
   while (j>1)and(A[j-1]>c) do 
    begin
     inc(sravneniya);
     inc(perestanovki);
     A[j]:=A[j-1];
     dec(j);
    end;
   A[j]:=c;
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