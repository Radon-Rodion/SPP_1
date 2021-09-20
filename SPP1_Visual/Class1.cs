using System;
using System.IO;

namespace SortLibrary
{
    public class Class1
    {
        const long LINES_IN_MEMORY = 1000;

        //поблочное чтение исходного файла и обработка блоков
        public static void ProcessFile(string inputFileName, string outputFileName)
        {
            int tempFilesAmount = 0;
            StreamReader reader = new StreamReader(inputFileName);
            string[] lines = new string[LINES_IN_MEMORY]; long i;
            for (i = 0; (lines[i] = reader.ReadLine()) != null; i++)
            {
                if (i == LINES_IN_MEMORY - 1)
                {
                    lines = SortLines(ref lines, i);
                    WriteToTempFile($"subResult{tempFilesAmount}.tmp", lines, i);
                    tempFilesAmount++;
                    i = 0;
                }
            }
            lines = SortLines(ref lines, i);
            WriteToTempFile($"subResult{tempFilesAmount}.tmp", lines, i);
            tempFilesAmount++;
            reader.Close();
            CombineFiles(outputFileName, tempFilesAmount);
            DeleteTempFiles(tempFilesAmount);
        }

        //запись массива строк во временный файл
        static void WriteToTempFile(string fileName, string[] lines, long nLines)
        {
            StreamWriter writer = new StreamWriter(fileName, true, System.Text.Encoding.Default);
            for (int i = 0; i < nLines; i++)
            {
                writer.WriteLine(lines[i]);
            }
            writer.Flush();
            writer.Close();
        }
        //сортировка строк
        public static string[] SortLines(ref string[] lines, long nLines)
        {
            return QuickSort(lines, 0, nLines - 1);
        }

        //метод для обмена элементов массива
        static void Swap(ref string x, ref string y)
        {
            var t = x;
            x = y;
            y = t;
        }

        //метод возвращающий индекс опорного элемента
        static long Partition(string[] array, long minIndex, long maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i].CompareTo(array[maxIndex]) < 0)
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }

        //быстрая сортировка
        static string[] QuickSort(string[] array, long minIndex, long maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = Partition(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        //объединение временных файлов в конечный
        static void CombineFiles(string outputFileName, int tempFilesAmount)
        {
            StreamReader[] readers = new StreamReader[tempFilesAmount];
            for (long i = 0; i < tempFilesAmount; i++)
                readers[i] = new StreamReader($"subResult{i}.tmp");

            string[] lestLines = new string[tempFilesAmount];
            for (long i = 0; i < tempFilesAmount; i++)
                lestLines[i] = readers[i].ReadLine();

            StreamWriter writer = new StreamWriter(outputFileName);
            long lestIndex;
            for (; ; )
            {
                lestIndex = -1;
                for (long i = 0; i < tempFilesAmount; i++)
                {
                    if (lestIndex == -1 && lestLines[i] != null)
                        lestIndex = i;
                    else if (lestLines[i] != null && lestLines[lestIndex].CompareTo(lestLines[i]) > 0)
                        lestIndex = i;
                }
                if (lestIndex != -1)
                {
                    writer.WriteLine(lestLines[lestIndex]);
                    lestLines[lestIndex] = readers[lestIndex].ReadLine();
                }
                else break;
            }
            for (long i = 0; i < tempFilesAmount; i++)
                readers[i].Close();
            writer.Flush();
            writer.Close();
        }

        static void DeleteTempFiles(long tempFilesAmount)
        {
            FileInfo fileInf;
            for (long i = 0; i < tempFilesAmount; i++)
            {
                fileInf = new FileInfo($"subResult{i}.tmp");
                fileInf.Delete();
            }
        }
    }
}
