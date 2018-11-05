public void Fizzbuzz()
{
  int j=1, k=1, l=0, m=1;
  bool Fizz, Buzz;
  string Output;

  for(int i=1;i<=100;i++)
  {
    Fizz = false;
    Buzz = false;
    if(j == 3)
    {
      Fizz = true;
      j = 1;
    }
    else
      j++;
    if(k == 5)
    {
      Buzz = true;
      k = 1;
    }
    else
      k++;
    if(l == 3 || m == 3)
      Fizz = true;
    if(l == 5 || m == 5)
      Buzz = true;
    if(m == 9)
    {
      m = 0;
      l++;
    }
    if(Fizz)
      if(Buzz)
        Output = "FizzBuzz";
      else
        Output = "Fizz";
    else
      if(Buzz)
        Output = "Buzz";
      else
        Output = i.ToString();
  }
}