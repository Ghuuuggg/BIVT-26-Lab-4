using System.Reflection.Metadata.Ecma335;

namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            double sum = 0;
            double count = 0;
            for (int i  = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                    count++;    
                }
            }
            double average = sum / count;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                  {
                    array[i] = average;
                }
            }
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
                        int firstNegative = -1;   

            for (int i = 0; i < array.Length && firstNegative == -1; i++)
            {
                if (array[i] < 0)
                {
                    firstNegative = i;
                }
            }

            if (firstNegative != -1)
            {
                for (int i = 0; i < firstNegative; i++)
                {
                    sum += array[i] * array[i];
                }
            }
            // end
            
            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here
            negatives = new int[0];
            if (array.Length == 0)
            {
                return negatives;
            }
            int maxIndex = 0;
            int minIndex = 0;
            for (int i = 0; i < array.Length; i++)

            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here

            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here

            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here

            // end

        }
        public void Task7(int[] array)
        {

            // code here

            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here

            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here

            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here

            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here

            // end

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here

            // end

            return wins;

        }
    }
}
