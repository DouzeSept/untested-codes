public int RomanToArabic(char[] Roman)
{
    int Arabic = 0, Num = 0, Temp = 1000;
    foreach(char c in Roman)
    {
        switch (c)
        {
            case 'I':
              Num = 1;
              break;
            case 'V':
              Num = 5;
              break;
            case 'X':
              Num = 10;
              break;
            case 'L':
              Num = 50;
              break;
            case 'C':
              Num = 100;
              break;
            case 'D':
              Num = 500;
              break;
            case 'M':
              Num = 1000;
              break;
         }
         if(Num > Temp)
           Arabic -= 2 * Temp;
         Arabic += Num;
         Temp = Num;
    }
    return Arabic;
}

public string ArabicToRoman(int Arabic)
{
  int Num, i = 0, j;
  string Roman = "";
  char[] Letters = {'I', 'V', 'X', 'L', 'C', 'D', 'M'};

  while (Arabic != 0)
  {
       Num = Arabic % 10;
       Arabic = Arabic / 10;
       if ((Num + 1) % 5 == 0)
         Roman = Letters[i].ToString() + Letters[i + (Num + 1) / 5].ToString() + Roman;
       else
       {
         for (j=0;j<(Num%5);j++)
           Roman = Letters[i].ToString() + Roman;
         for (j=0;j<(Num/5);j++)
           Roman = Letters[i + 1].ToString() + Roman;
       }
        i += 2;
  }
   return Roman;
}