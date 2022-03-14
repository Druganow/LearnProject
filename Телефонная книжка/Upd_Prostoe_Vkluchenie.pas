Program Upd_Prostoe_Vkluchenie;
const n=100000;
type omas=array [1..n+1] of integer;
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
var i,jMax,j,c:integer; sravneniya,perestanovki:int64;
begin
sravneniya:=0;
perestanovki:=0;
 for i:=n downto 2 do
  begin
   jMax:=1;
   for j:=2 to i do
    begin
     inc(sravneniya);
     if A[j]>A[jMax] then jMax:=j;
    end;
   if jMax<>j then begin inc(perestanovki); c:=A[i]; A[i]:=A[jMax]; A[jMax]:=c; end;
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