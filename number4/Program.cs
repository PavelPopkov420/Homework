int N = Convert.ToInt32(Console.ReadLine());
int i = 1, k = 1;
while (true)
{
	if (i % 2 == 0)
	{
		Console.Write(i + " ");
		k++;
	}
	if (k > N)
	{
		break;
	}
	i++;
}
