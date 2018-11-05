public void FooBarQix()
{
  int j=1, k=1, l=1, m, n;
  string Output, NumStr;

  for(int i=1;i<=1000;i++)
  {
    Output = "";
    if(j == 3)
    {
      Output += "Foo";
      j = 1;
    }
    else
      j++;
    if(k == 5)
    {
      Output += "Bar";
      k = 1;
    }
    else
      k++;
    if(l == 7)
    {
      Output += "Qix";
      l = 1;
    }
    else
      l++;
    m = i;
    NumStr = "";
    while(m != 0)
    {
      n = m % 10;
      m = m / 10;
      switch(n)
      {
        case 3:
          Output += "Foo";
          break;
        case 5:
          Output += "Bar";
          break;
        case 7:
          Output += "Qix";
          break;
        case 0:
          if(Output != "")
            Output += "*";
          NumStr = "*" + NumStr;
          break;
        default:
          NumStr = n.ToString() + NumStr;
          break;
      }
    }
    if (Output == "")
      Output = NumStr;
  }
}