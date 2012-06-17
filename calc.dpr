{$APPTYPE CONSOLE}

const
  MaxN = 1000;
  MaxK = 10;

var
  RezFin, Kredit, ZatrProd, betta, V_Prod_Min: Real;
  ZatrEdProd, PriseEdProd: Real;
  n: integer;
  { ����� ���������� ��������������� ������������� m }
  V_Prod, A_prod: array [0 .. MaxN] of Real;

Type
  TProduct = record
    Name: string;
    ZatrEdProd: Real;
    PriseEdProd: Real;
    V_Prod, A_prod: array [0 .. MaxN] of Real;
  end;

Var
  Product: array [1 .. MaxK] of TProduct;

Var
  i, j, temp, kVp, nPer, mPer: integer;
  fOutFile: Text;
  sFileName: string;
  Prib: double;

  { ������� p������ �������� ����� }
Function Dohod(n, m: integer; Product: TProduct; betta: Real): Real;
var
  i: integer;
  temp: Real;
Begin
  temp := 0;
  for i := 1 to m do
  begin
    temp := temp + Product.V_Prod[n - i] * Product.A_prod[i];
  end;
  Dohod := temp * (1 - betta) * Product.PriseEdProd;
End;

begin
  repeat
    { ���� ������ �p��p������ �������� }
    for i := 1 to 8 do
      writeln;
    writeln('        *****************************');
    writeln('        *                           *');
    writeln('        *                           *');
    writeln('        *  ��������� ������� ������ *');
    writeln('        *        ������������       *');
    writeln('        *                           *');
    writeln('        *                           *');
    writeln('        *****************************');
    { ���� ����� �������� ������ }
    { ������ � �p���p����� }
    write('����������� p���p���� �p������ �p���p�����: ');
    readln(RezFin);
    write('����� �p������, ���������� �p���p������:   ');
    readln(Kredit);
    write('����� ���������� ���p�� �p���p�����:   ');
    readln(ZatrProd);
    write('�p�������� ������ ������ �� �p�����:   ');
    readln(betta);
    write('���������� ����� �p������� (�� ����� 10):   ');
    readln(kVp);
    { ���� ������ � �p������� }
    for i := 1 to kVp do
    begin
      writeln('������ � �p������� ', i, ' - �� ����.');
      with Product[i] do
      begin
        write('  �������� �p�������:   ');
        readln(Name);
        write('    ���p��� �� ������� �p�������: ');
        readln(ZatrEdProd);
        write('    �������� ���� ������� �p�������: ');
        readln(PriseEdProd);
        write('����� ��p����� ������� �p�������:   ');
        readln(nPer);
        mPer := 0;
        for j := 0 to nPer do
        begin
          writeln('� ��p��� n-', j, ':   ');
          if j = 0 then
            write('  - ����� ����������� �p�������:X')
          else
          begin
            write('  - ����� ����������� �p�������: ');
            readln(V_Prod[nPer - j]);
          end;
          write('       - �������� ��� �� ����������: ');
          readln(A_prod[j]);
          if A_prod[j] <> 0 then
            mPer := 0;
        end;
      end;
      { ��������� ����� ��� ���������� ���� ��������� }

      { ������ ������ �p���������� }
      V_Prod[n] := (RezFin + Kredit + Dohod(nPer, mPer, Product[i], betta) -
        ZatrProd) / Product[i].ZatrEdProd - (1 - betta) * Product[i].A_prod[0] *
        Product[i].PriseEdProd;
      { ������ �p����� }
      Prib := Dohod(nPer, mPer, Product[i], betta) + (1 - betta) * Product[i]
        .PriseEdProd * V_Prod[n] * Product[i].A_prod[0] -
        (V_Prod[n] * Product[i].ZatrEdProd + ZatrProd);

      writeln('���������� ��������� ������? ��-1 ���-0');
      read(temp);
      case temp of
        0:
          // graphic;
          break;
        1: { ����������� ����� ������������� ������������ ��� ������ ���������� ��������� }
          V_Prod_Min := (ZatrProd - Dohod(nPer, mPer, Product[i], betta)) /
            ((1 - betta) * Product[i].PriseEdProd * Product[i].A_prod[0] -
            Product[i].ZatrEdProd);
      end;

      writeln('�p� ��������� �p������� ��������� ����� ������� �p������� �������� V_Prod[m]=',
        V_Prod[mPer]:7:2);
      writeln(Prib:7:2);
      Write(V_Prod_Min:7:2);

      writeln('��������� ������ � �����? ��-1 ���-0');
      Read(temp);
      if temp = 1 then
      begin
        readln(sFileName);
        Assign(fOutFile, sFileName);
        Rewrite(fOutFile);
        writeln(fOutFile,
          '�p� ��������� �p������� ��������� ����� ������� �p������� ��������',
          V_Prod[mPer]:7:2);
        writeln(fOutFile, Prib:7:2);
        writeln(fOutFile, V_Prod_Min:7:2);
        Close(fOutFile);
      end;

    end;
    writeln('��������� �������? ��-1 ���-0');
    Read(temp);
  until temp = 0;

end.
