Program Sortirovka_Sliyaniyami;
const n=100000;
type omas=array [1..n] of integer;
var a: omas; sravneniya,perestanovki:int64;

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

procedure Sliyanie(var A:omas; l, r: integer);
var middle,start,final,j:integer; mas:omas;
begin
 middle:=(l+r) div 2; {вычисление среднего элемента}
 start:=l; {начало левой части}
 final:=middle+1; {начало правой части}
 for j:=l to r do {выполнять от начала до конца}
  begin
   inc(sravneniya);
   if (start<=middle) and ((final>r) or (A[start]<A[final])) then
    begin
     if a[l]>a[r] then inc(perestanovki);
     mas[j]:=A[start];
     inc(start);
    end
   else
    begin
     if a[r]>a[l] then inc(perestanovki);
     mas[j]:=A[final];
     inc(final);
    end;
   end;
  for j:=l to r do A[j]:=mas[j];
end;

procedure Sortirovka(var A: omas; l, r: integer);
begin
if l<r then
 begin
  Sortirovka(A, l, (l+r) div 2); {сортировка левой части}
  Sortirovka(A, (l+r) div 2+1, r); {сортировка правой части}
  Sliyanie(A, l, r); {слияние двух частей}
 end;
end;



BEGIN
init(a);
//print(a);
Sortirovka(A,1,n);
writeln('изменённый массив');
//print(a);
writeln('сравнений произошло:',sravneniya);
writeln('перестановок произошло:',perestanovki);
END.