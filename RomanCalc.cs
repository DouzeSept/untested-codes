char[] Letters = {'I', 'V', 'X', 'L', 'C', 'D', 'M'};

public string RomanAdd(char[]Roman1, char[]Roman2)
{
  int[] Count = {0, 0, 0, 0, 0, 0, 0};
  string Output = "";
  int Pos = -1;
  CountLetters(Count, Roman1);
  CountLetters(Count, Roman2);
  for (int i=0; i<7; i++)
  {
    if (Count[i] < 0)
      Pos = i;
    else
      for(int j=0; j<Count[i]; j++)
      {
        Output = Letters[i].ToString() + Output;
        if (Pos >= 0)
        {
          Output = Letters[Pos].Tostring() + Output;
          Pos = -1;
        }
      }
  }
  return Output;
}

private void CountLetters(int[]Count, char[]Source)
{
  int Temp = 0;
  for (int i=Source.Length; i >=0; i--)
    for (j=0;j<7;j++)
      if (Source[i] == Letters[j])
      {
        if (j < Temp)
          Sub(Count, j);
        else
          Inc(Count, j);
        Temp = j;
        break;
      }
}

private void Sub(int[]Count, int Pos)
{
  if (Pos % 2 = 1)
  {
    if (Count[Pos] == 0)
      Sub(Count, Pos + 1);
    Count[Pos] = -(Count[Pos]-1);
  }
  else
    if (Count[Pos] == -1)
    {
      Sub(Count, Pos + 1);
      Count[Pos] = 3;
    }
    else
      Count[Pos] -= 1;
}

private void Inc(int[]Count, int Pos)
{
  if (Pos % 2 = 1)
  {
    if (Count[Pos] == 1)
      Inc(Count, Pos + 1);
    Count[Pos] = -(Count[Pos]-1);
  }
  else
    if (Count[Pos] == 3)
    {
      Inc(Count, Pos + 1);
      Count[Pos] = -1;
    }
    else
      Count[Pos] += 1;
}