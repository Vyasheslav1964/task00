// See https://aka.ms/new-console-template for more information
int[,] ArrayStringInDescendingOder(int[,] matrixD)
{
    // контейнер для замены значения

    for (int i = 0; i < matrixD.GetLength(0); i++)  //цикл по строкам 
    {
        for (int j = 0; j < matrixD.GetLength(1); j++)
        {
            for (int k = 0; k < matrixD.GetLength(0); k++)
            {
                for (int l = 0; l < matrixD.GetLength(1); l++)
                {
                    if (k + 1 == matrixD.GetLength(0) || l + 1 == matrixD.GetLength(1))
                    {
                        continue;
                    }
                    else
                    {
                        if (l + 1 == matrixD.GetLength(1) || matrixD[k, l] > matrixD[k + 1, 0])
                        {
                            int temp = matrixD[k, l];
                            matrixD[k, l] = matrixD[k + 1, l];
                            matrixD[k + 1, l] = temp;
                        }
                        else
                        {
                            if (matrixD[k, l] > matrixD[k, l + 1])
                            {
                                int temp = matrixD[k, l];
                                matrixD[k, l] = matrixD[k, l + 1];
                                matrixD[k, l + 1] = temp;
                            }
                        }
                    }
                }
            }
        }

    }
    return matrixD;
}