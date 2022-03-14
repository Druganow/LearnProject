Program Shaker_Sort;
const n=10;
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
var i,j,c:integer; sravneniya,perestanovki:int64; l,r:integer;
begin
sravneniya:=0;
perestanovki:=0;
l:=2;
r:=n;
while l<=r do
 begin
  for j:=l to r do
   begin
    inc(sravneniya);
    if A[j]<A[j - 1] then begin inc(perestanovki); c:=A[j]; A[j]:=A[j-1]; A[j-1]:=c; end;
   end;
  dec(r);
  for j:=r downto l do
   begin
    inc(sravneniya);
    if A[j]<A[j - 1] then begin inc(perestanovki); c:=A[j]; A[j]:=A[j-1]; A[j-1]:=c; end;
   end;
  inc(l);
 end;
writeln('сравнений произошло:',sravneniya);
writeln('перестановок произошло:',perestanovki);
end;

BEGIN
init(a);
print(a);
Sortirovka(a);
writeln('изменённый массив');
print(a);
END.
