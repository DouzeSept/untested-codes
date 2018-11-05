public void KataPotter（）
{
    int[] Orders = new int{112, 123, 234, 321, 211};
    int Size;
    double Price = 0;

    do
    {
        Size = 0;
        for(int i=0; i<5; i++)
          if(Orders[i] != 0)
          {
            Orders[i] -= 1;
            Size += 1;
          }
        switch(Size)
        {
            case 1:
                Price += 8;
                break;
            case 2:
                Price += 15.2;
                break;
            case 3:
                Price += 21.6;
                break;
            case 4:
                Price += 25.6;
                break;
            case 5:
                Price += 30;
                break;
        }
     } while(Size != 0);
}