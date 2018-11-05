public string GetAllAnagrams(string Prefix, char[] Letters)
{
  string s, Output = "";
  int l = Letter.Length;
  if(l == 1)
  {
    s = Prefix + Letters[0].ToString();
    if(InDictionary(s))
      return s;
    else
      return "";
  }
  else
  {
    char[] ca = new char[l - 1];
    for(int i=0; i<l; i++)
    {
      for(int j=0, k=0; j<l; j++, k++)
        if(i == j)
          j++;
        else
          ca[k] = Letters[j];
      s = GetAllAnagrams(Prefix + Letters[i].ToString(), ca);
      if(s != "")
      {
        if(Output != "")
          Output += " ";
        Output += s;
      }
    }
  }
  return Output;
}