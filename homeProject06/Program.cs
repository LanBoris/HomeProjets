// Назовём число «интересным», если его произведение 
// цифр делится на их сумму. Напишите программу, 
// которая заполняет массив на 10 «интересных» случайных 
// целых чисел от 10 до 1000. (каждый эл-т массива – сгенерирован случайно)

// [591, 532, 189, 523, 333, 546, 527, 275, 456, 264]

// string stringNumber = number.ToString();
// char[] sN = stringNumber.ToCharArray();
// if (sN.Length % 2 == 1)
// {
//   char cD = sN[sN.Length / 2];
//   int centerDigit = (int)Char.GetNumericValue(cD);


for (int num = 10; num <= 999; num++)
{
  int numb=0;
  string sn = num.ToString();
  char[] n = sn.ToCharArray();
  if (n.Length == 2)
  {
    char n1 = sn[0];
    char n2 = sn[1];
    int in1 = (int)Char.GetNumericValue(n1);
    int in2 = (int)Char.GetNumericValue(n2);
    if ((in1 * in2) % (in1 + in2) == 0 && (in1 * in2) / (in1 + in2) > 0)
    {
      numb=num;
    }
  }
  else if (n.Length == 3)
  {
    char n1 = sn[0];
    char n2 = sn[1];
    char n3 = sn[2];
    int in1 = (int)Char.GetNumericValue(n1);
    int in2 = (int)Char.GetNumericValue(n2);
    int in3 = (int)Char.GetNumericValue(n3);
    if ((in1 * in2 * in3) % (in1 + in2 + in3) == 0 && (in1 * in2 * in3) / (in1 + in2 + in3) > 0)
    {
      numb=num;
    }
  }
  if (numb>0)
  {
    Console.Write(numb + "-");
  }
}

// int i =0;
// int[] array=new int[10];
// while (i<10)
// {
  
// }
