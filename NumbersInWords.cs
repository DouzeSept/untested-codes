public string NumberToWords(ulong Num)
{
  int[] a;
  int j, k, l;
  int IsZero = true;
  string Output = "", ConnectStr = "";
  string[] arrUnit = {"", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen","ninteen"};
  string[] arrTen = {"", "", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninty"};
  String[] arr000 = {"", " thousand", " million", " billion", " trillion"," quadrillion", " quintillion"};
  l = Num.ToString().Length;
  a = new int[l];
  for(int i=l-1; i>=0; i--)
  {
    a[i] = Num % 10;
    Num = Num / 10;
  }
  j = (l - 1) / 3;
  k = (l - 1) % 3;
  for(int i=0; i<l; i++)
  {
    if(a[i] > 0)
    {
      IsZero = false;
      if(ConnectStr == "; " && j == 0)
        ConnectStr = " and ";
      Output += ConnectStr();
      if(k == 1)
      {
        if(a[i] == 1)
        {
          Output += arrUnit[a[i]*10 + a[i+1]];
          i++;
          k--;
        }
        else
        {
          Output += arrTen[a[i]];
          ConnectStr = " ";
        }
      }
      else
      {
        Output += arrUnit[a[i]];
        if(k == 2)
        {
          Output += " hundred";
          ConnectStr = " and ";
        }
      }
    }
    if(k == 0)
    {
      if(!IsZero)
      {
        Output + = arr000[j];
        ConnectStr = "; ";
      }
      k = 2;
      j--;
    }
    else
      k--;
  }
  if (Output == "")
    Output = "zero";
  return Output;
}

public ulong WordsToNumber(string Words)
{
  int Temp = 0;
  ulong Output = 0;
  string[] arrStr = Words.Split(new char[]{' ', ','});

  foreach(string c in arrStr)
    switch(c)
    {
      case "one":
        Temp += 1;
        break;
      case "two":
        Temp += 2;
        break;
      case "three":
        Temp += 3;
        break;
      case "four":
        Temp += 4;
        break;
      case "five":
        Temp += 5;
        break;
      case "six":
        Temp += 6;
        break;
      case "seven":
        Temp += 7;
        break;
      case "eight":
        Temp += 8;
        break;
      case "nine":
        Temp +=9;
        break;
      case "ten":
        Temp += 10;
        break;
      case "eleven":
        Temp += 11;
        break;
      case "twelve":
        Temp += 12;
        break;
      case "thirteen":
        Temp += 13;
        break;
      case "fourteen":
        Temp += 14;
        break;
      case "fifteen":
        Temp += 15;
        break;
      case "sixteen":
        Temp += 16;
        break;
      case "seventeen":
        Temp += 17;
        break;
      case "eighteen":
        Temp += 18;
        break;
      case "ninteen":
        Temp += 19;
        break;
      case "twenty":
        Temp += 20;
        break;
      case "thirty":
        Temp += 30;
        break;
      case "fourty":
        Temp += 40;
        break;
      case "fifty":
        Temp += 50;
        break;
      case "sixty":
        Temp += 60;
        break;
      case "seventy":
        Temp += 70;
        break;
      case "eighty":
        Temp += 80;
        break;
      case "ninty":
        Temp += 90;
        break;
      case "hundred":
        Temp *= 100;
        break;
      case "thousand":
        Output += Temp * 1000;
        Temp = 0;
        break;
      case "million":
        Output += Temp * 1000000;
        Temp = 0;
        break;
    }
  Output += Temp;
  return Output;
}