namespace MathAplications
{
    public class Statistics {
        /// <summary>
        /// Girilen sayı kadar elamanlı 1-100 arasındaki sayılardan dizi oluşturur.
        /// </summary>
        public int[] CreateData (int n) {
          
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = new Random().Next(0, 100);
            }
            return numbers;
        }

        /// <summary>
        /// Parametre olarak aldığı diziyi ekrana yazdırır.
        /// </summary>
        /// <param name="datas">Dizi</param>
        public static void ArrayPrint (int[] datas) {
            Console.WriteLine("");
            for (int i = 0; i < datas.Length; i++)
            {
                Console.Write("{0, 3}", datas[i]);
            }
            Console.WriteLine("");
        }

        /// <summary>
        /// Sayılardan oluşan dizinin en büyük elemanını döner.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int BiggestData (int[] datas) {
            int bigData = datas[0];
            for (int i = 0; i < datas.Length; i++)
            {
                if (datas[i] > bigData)
                {
                    bigData = datas[i];
                }
            }
            return bigData;
        }

        /// <summary>
        /// Sayılardan oluşan dizinin en küçük elemanını döner.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int SmallestData (int[] datas) {
            int smallData = datas[0];
            for (int i = 0; i < datas.Length; i++)
            {
                if (datas[i] < smallData)
                {
                    smallData = datas[i];
                }
            }
            return smallData;
        }

        /// <summary>
        /// Veriler aritmetik ortalamasını hesaplar.
        /// </summary>
        /// <param name="datas">Dizi</param>
        /// <returns></returns>
        public static double ArithmeticMean (int[] datas) {
            double total = 0;
            for (int i = 0; i < datas.Length; i++)
            {
                total += datas[i];
            }
            return total / datas.Length;
        }

        /// <summary>
        /// Parametre olarak aldığı dizinin standart sapmasını hesaplar.
        /// </summary>
        /// <param name="datas">Dizi</param>
        /// <returns>Standart sapma</returns>
        public static double StandardDeviation (int[] datas) {
            
            double arithmeticMean = ArithmeticMean(datas);
            double t = 0, f = 0;

            for (int i = 0; i < datas.Length; i++)
            {
                f = datas[i] - arithmeticMean;
                t += Math.Pow(f, 2);
            }

            return Math.Sqrt(t / (datas.Length - 1));
            
        }

        /// <summary>
        /// Parametre olarak aldığı dizinin içindeki tek sayıların sayısını döner.
        /// </summary>
        /// <param name="datas">Dizi</param>
        /// <returns>Tek sayıların sayısı</returns>
        public static int NumberOfOddNumbers (int[] datas) {
            int numberOfOddNumbers = 0;
            for (int i = 0; i < datas.Length; i++)
            {
                if (datas[i] % 2 == 1)
                {
                    numberOfOddNumbers++;
                }
            }
            return numberOfOddNumbers;
        }

        /// <summary>
        /// Parametre olarak aldığı dizinin içindeki çift sayıların sayısını döner.
        /// </summary>
        /// <param name="datas">Dizi</param>
        /// <returns>Çift sayıların sayısı</returns>
        public static int NumberOfEvenNumbers (int[] datas) {
            int numberOfEvenNumbers = 0;
            for (int i = 0; i < datas.Length; i++)
            {
                if (datas[i] % 2 == 0)
                {
                    numberOfEvenNumbers++;
                }
            }
            return numberOfEvenNumbers;
        }

        /// <summary>
        /// Parametre olarak gelen dizinin içindeki tek sayılardan yeni bir dizi döner.
        /// </summary>
        /// <param name="datas">Dizi</param>
        /// <returns>Tek sayılardan dizi</returns>
        public int[] CreateOddArray (int[] datas) {
            int[] oddArray = new int[NumberOfOddNumbers(datas)];
            int y = 0;
            for (int i = 0; i < datas.Length; i++)
            {
                if (datas[i] % 2 == 1)
                {
                    oddArray[y] = datas[i];
                    y++;
                }
            }
            return oddArray;
        }

        /// <summary>
        /// Parametre olarak gelen dizinin içindeki çift sayılardan yeni bir dizi döner.
        /// </summary>
        /// <param name="datas">Dizi</param>
        /// <returns>Çift sayılardan dizi</returns>
        public int[] CreateEvenArray (int[] datas) {
            int[] evenArray = new int[NumberOfEvenNumbers(datas)];
            int y = 0;
            for (int i = 0; i < datas.Length; i++)
            {
                if (datas[i] % 2 == 0)
                {
                    evenArray[y] = datas[i];
                    y++;
                }
            }
            return evenArray;
        }

    }
}