Program Quick_Sort;
const n=10;
type omas=array [1..n] of integer;
var a: omas; sravneniya,perestanovki:int64;

Procedure init(var a:omas);
var i:integer;
begin
for i:=1 to n do
 //readln(A[i]);
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

procedure Sortirovka(m,l:integer); 
var
  i,j,x,w,xi: integer;
begin
  i:=m;
  j:=l;
  x:=a[(m+l) div 2];
  xi:=(m+l) div 2;
  repeat
    while (a[i]<x)  do 
     begin;
      inc(sravneniya);
      inc(i);
     end;
    while (a[j]>x)  do 
    begin
     if a[j]=x then j:=xi;
     dec(j);
     inc(sravneniya);
    end;
    if i<=j then 
     begin
      inc(perestanovki);
      w:=a[i];
      a[i]:=a[j];
      a[j]:=w;
     end;
  until (i<j);
  if (j-m)>1 then Sortirovka(m,j-1);
  if (l-i)>1 then Sortirovka(i+1,l);
end;
 


BEGIN
init(a);
print(a);
Sortirovka(1,n);
writeln('изменённый массив');
print(a);
writeln('сравнений произошло:',sravneniya);
writeln('перестановок произошло:',perestanovki);
END.