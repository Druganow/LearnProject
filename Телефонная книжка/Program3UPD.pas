type
  arr = array of integer;

var
  a, b: arr;
  n: integer;

procedure inc(var a:int64);
begin
  a:=a+1;
end;

procedure swap(var a: arr; i, j: integer);
var
  t: integer;
begin
  t := a[i];
  a[i] := a[j];
  a[j] := t;
end;

procedure createArr(var a: arr; modification: integer);
begin
  for i: integer := 0 to a.Length - 1 do
    if modification = 1 then
      a[i] := i
    else if modification = 2 then
      a[i] := n - i
    else if modification = 4 then
      a[i] := Random(n)
    else
      a[i] := b[i];
end;

function check(var a: arr): boolean;
var
  i: integer;
begin
  result := true;
  i := 0;
  while result and (i < a.Length - 1) do
  begin
    if a[i] > a[i + 1] then result := false;
    inc(i);
  end;
end;

procedure selectionSort(var a: arr);
var
  max, maxIndex: integer;
  countSwap, countComp, countCompElements: int64;
  i, j: integer;
begin
  write('1 selectionSort =    ');
  i := a.Length - 1;
  inc(countComp);
  while i > 0 do
  begin
    max := a[0];
    maxIndex := 0;
    j := 1;
    inc(countComp);
    while j <= i do
    begin
      inc(countComp);
      inc(countCompElements);
      if a[j] > max then
      begin
        max := a[j];
        maxIndex := j;
      end;
      inc(j);
      inc(countComp);
    end;
    inc(countComp);
    if i <> maxIndex then
    begin
      inc(countSwap);
      swap(a, i, maxIndex);
    end;
    dec(i);
    inc(countComp);
  end;
  writeln(countSwap, ' ', countComp, ' (', countCompElements, ') ', check(a));
end;

procedure bubbleSort(var a: arr);
var
  countSwap, countComp, countCompElements: int64;
  i, j: integer;
begin
  write('2 bubbleSort =       ');
  i := a.Length - 1;
  inc(countComp);
  while i > 0 do
  begin
    inc(countComp);
    j := 0;
    while j < i do
    begin
      inc(countComp);
      inc(countCompElements);
      if a[j] > a[j + 1] then
      begin
        inc(countSwap);
        swap(a, j, j + 1);
      end;
      inc(countComp);
      inc(j);
    end;
    inc(countComp);
    dec(i);
  end;
  writeln(countSwap, ' ', countComp, ' (', countCompElements, ') ', check(a));
end;

procedure UPDbubbleSort(var a: arr);
var
  tr: boolean;
  index, i, j: integer;
  countSwap, countComp, countCompElements: int64;
begin
  write('3 UPDbubbleSort =    ');
  index := 0;
  tr := true;
  i := a.Length - 1;
  inc(countComp);
  while (i > 0) and tr do
  begin
    tr := false;
    j := index;
    inc(countComp);
    while j < i do
    begin
      inc(countComp);
      inc(countCompElements);
      if a[j] > a[j + 1] then
      begin
        inc(countSwap);
        swap(a, j, j + 1);
        if not tr then
          index := j - 1;
        if index = -1 then
          index := 0;
        tr := true;
      end;
      inc(countComp);
      inc(j);
    end;
    dec(i);
    inc(countComp);
  end;
  writeln(countSwap, ' ', countComp, ' (', countCompElements, ') ', check(a));
end;

procedure shakerSort(var a: arr);
var
  countSwap, countComp, countCompElements: int64;
  tr: boolean;
  l, r, i: integer;
begin
  write('4 shakerSort =       ' );
  tr := true;
  l := 0; r := a.Length - 1;
  while tr do
  begin
    tr := false;
    i := l;
    inc(countComp);
    while i < r do
    begin
      inc(countComp);
      Inc(countCompElements);
      if a[i] > a[i + 1] then
      begin
        tr := true;
        inc(countSwap);
        swap(a, i, i + 1);
      end;
      inc(countComp);
      inc(i);
    end;
    dec(r);
    i := r;
    if tr then
      inc(countComp);
    while i > l do
    begin
      inc(countComp);
      Inc(countCompElements);
      if a[i] < a[i - 1] then
      begin
        tr := true;
        inc(countSwap);
        swap(a, i, i - 1);
      end;
      dec(i);
      inc(countComp);
    end;
    inc(l);
    inc(countComp);
    i := l;
  end;
  writeln(countSwap, ' ', countComp, ' (', countCompElements, ') ', check(a));
end;

procedure insertionSort(var a: arr);
var
  countSwap, countComp, countCompElements: int64;
  i, j, k, t: integer;
begin
  write('5 insertionSort =    ' );
  inc(countComp);
  if a.Length > 1 then
  begin
    inc(countCompElements);
    if a[0] > a[1] then
    begin
      inc(countSwap);
      swap(a, 1, 0);
    end;
    k := 2;
    inc(countComp);
    while k < a.Length do
    begin
      inc(countCompElements);
      if a[k] < a[k - 1] then
      begin
        i := k - 1;
        t := a[k];
        inc(countComp);
        if i > 0 then
          inc(countCompElements);
        while(i > 0) and (a[i - 1] > t) do
        begin
          dec(i);
          inc(countComp);
          if i > 0 then
            inc(countCompElements);
        end;
        j := k;
        inc(countComp);
        while j > i do
        begin
          a[j] := a[j - 1];
          dec(j);
          inc(countSwap);
        end;
        inc(countSwap);
        a[i] := t;
      end;
      inc(k);
      inc(countComp);
    end;
  end;
  writeln(countSwap, ' ', countComp + countCompElements, ' (', countCompElements, ') ', check(a));
end;

procedure UPDinsertionSort(var a: arr);
var
  countSwap, countComp, countCompElements: int64;
  i, j, k: integer;
  b: arr;
begin
  write('6 UPDinsertionSort = ' );
  inc(countComp);
  if a.Length > 1 then
  begin
    SetLength(b, a.Length + 1);
    for i := 0 to a.Length - 1 do
      b[i + 1] := a[i];
    inc(countCompElements);
    if b[1] > b[2] then
    begin
      inc(countSwap);
      swap(b, 1, 2);
    end;
    k := 3;
    inc(countComp);
    while k < b.Length do
    begin
      inc(countCompElements);
      if b[k] < b[k - 1] then
      begin
        i := k - 1;
        b[0] := b[k];
        inc(countCompElements);
        while(b[i - 1] > b[0]) do
        begin
          dec(i);
          inc(countCompElements);
        end;
        j := k;
        inc(countComp);
        while j > i do
        begin
          b[j] := b[j - 1];
          dec(j);
          inc(countSwap);
        end;
        inc(countSwap);
        b[i] := b[0];
      end;
      inc(k);
      inc(countComp);
    end;
  end;
  for i := 0 to a.Length - 1 do
    a[i] := b[i + 1];
  writeln(countSwap, ' ', countComp + countCompElements, ' (', countCompElements, ') ', check(a));
end;

procedure _merge(var a: arr; l, r: integer; var countSwap, countComp, countCompElements: int64);
var
  b: arr;
  i, j, k: integer;
begin
  SetLength(b, r - l + 1);
  i := l;
  j := (l + r) div 2 + 1;
  k := 0;
  inc(countComp);
  while k < b.Length do
  begin
    inc(countComp);
    if i < (l + r) div 2 + 1 then
    begin
      inc(countCompElements);
      if (a[i] <= a[j]) then
      begin
        inc(countSwap);
        b[k] := a[i];
        inc(k);
        inc(i);
      end;
    end;
    inc(countComp);
    if i = (l + r) div 2 + 1 then
    begin
      inc(countComp);
      while j <= r do
      begin
        inc(countSwap);
        b[k] := a[j];
        inc(k);
        inc(j);
        inc(countComp);
      end;
    end;
    inc(countComp);
    if j <= r then
    begin
      inc(countCompElements);
      if (a[i] >= a[j]) then
      begin
        inc(countSwap);
        b[k] := a[j];
        inc(k);
        inc(j);
      end;
    end;
    inc(countComp);
    if j > r then
    begin
      inc(countComp);
      while i < (l + r) div 2 + 1 do
      begin
        inc(countSwap);
        b[k] := a[i];
        inc(k);
        inc(i);
        inc(countComp);
      end;
    end;
    inc(countComp);
  end;
  k := 0;
  inc(countComp);
  while k < b.Length do
  begin
    inc(countSwap);
    a[l + k] := b[k];
    inc(k);
    inc(countComp);
  end;
end;

procedure  _mergeSort(var a: arr; l, r: integer; var countSwap, countComp, countCompElements: int64);
begin
  inc(countComp);
  if r - l = 1 then
  begin
    inc(countCompElements);
    if a[r] < a[l] then
    begin
      inc(countSwap);
      swap(a, l, r);
    end;
  end
  else
  begin
    inc(countComp);
    if r - l > 1 then
    begin
      _mergeSort(a, l, (l + r) div 2, countSwap, countComp, countCompElements);
      _mergeSort(a, (l + r) div 2 + 1, r, countSwap, countComp, countCompElements);
      _merge(a, l, r, countSwap, countComp, countCompElements);
    end;
  end;
end;

procedure  mergeSort(var a: arr);
var
  countSwap, countComp, countCompElements: int64;
begin
  write('7 mergeSort =        ' );
  _mergeSort(a, 0, (a.Length - 1) div 2, countSwap, countComp, countCompElements);
  _mergeSort(a, (a.Length - 1) div 2 + 1, a.Length - 1, countSwap, countComp, countCompElements);
  _merge(a, 0, a.Length - 1, countSwap, countComp, countCompElements);
  writeln(countSwap, ' ', countComp + countCompElements, ' (', countCompElements, ') ', check(a));
end;

procedure  _quickSort(var a: arr; l, r: integer; var countSwap, countComp, countCompElements: int64);
var
  i, j, x: integer;
begin
  i := l;
  j := r;
  x := a[(i + j) div 2];
  repeat 
    inc(countCompElements);
    while a[i] < x do
    begin
      inc(countCompElements);
      inc(i);
    end;
    inc(countCompElements);
    while a[j] > x do
    begin
      inc(countCompElements);
      dec(j);
    end;
    inc(countComp);
    if i<=j then
    begin
      inc(countSwap);
      swap(a, j, i);
      inc(i);
      dec(j);
    end;
    inc(countComp);
  until i>j;
  inc(countComp);
  if l<j then 
    _quickSort(a, l, j, countSwap, countComp, countCompElements);
  inc(countComp);
  if i<r then
    _quickSort(a, i, r, countSwap, countComp, countCompElements);
end;

procedure quickSort(var a: arr);
var
  countSwap, countComp, countCompElements: int64;
begin
  write('7 quickSort =        ' );
  _quickSort(a, 0, a.Length - 1, countSwap, countComp, countCompElements);
  writeln(countSwap, ' ', countComp + countCompElements, ' (', countCompElements, ') ', check(a));
end;

begin
  n := 100000;
  SetLength(a, n);
  SetLength(b, n);
  createArr(b, 4);
  for i: integer := 1 to 3 do
  begin
    writeln(i);
    createArr(a, i);
    selectionSort(a);
    createArr(a, i);
    bubbleSort(a);
    createArr(a, i);
    UPDbubbleSort(a);
    createArr(a, i);
    shakerSort(a);
    createArr(a, i);
    insertionSort(a);
    createArr(a, i);
    UPDinsertionSort(a);
    createArr(a, i);
    mergeSort(a);
    createArr(a, i);
    quickSort(a);
  end;
end.