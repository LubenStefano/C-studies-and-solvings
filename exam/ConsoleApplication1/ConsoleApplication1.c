#include <stdio.h>
int main()
{

	//Exercise1();
	Exercise2();

	return 0;
}

static void Exercise1()
{
	float A[5][3];

	int i, j;

	for (i = 0; i < 5; i++)
	{
		for (j = 0; j < 3; j++)
		{
			printf("Enter the price for %i city %i product:  \n", i + 1, j + 1);
			scanf_s("%f", &A[i][j]);
		}
	}

	float minPrices[3];


	for (j = 0; j < 3; j++)
	{
		minPrices[j] = A[0][j];
		for (i = 1; i < 5; i++)
		{
			if (A[i][j] < minPrices[j])
			{
				minPrices[j] = A[i][j];
			}
		}
	}

	for (j = 0; j < 3; j++)
	{
		printf("The minimum price for product %i is: %.2f\n", j + 1, minPrices[j]);
	}
}

int Exercise2()
{
	float A[3][10];

	for (int i = 0; i < 3; i++)
	{
		for (int j = 0; j < 10; j++)
		{
			printf("Enter the temp %i for city %i:  \n", j + 1, i + 1);
			scanf_s("%f", &A[i][j]);
		}
	}

	float maxTemp[3];


	for (int j = 0; j < 3; j++)
	{
		maxTemp[j] = A[0][j];
		for (int i = 1; i < 10; i++)
		{
			if (A[i][j] > maxTemp[j])
			{
				maxTemp[j] = A[i][j];
			}
		}
	}

	for (int j = 0; j < 3; j++)
	{
		printf("The max temp for city %i is: %.2f \n", j + 1, maxTemp[j]);
	}

	return 0;
}