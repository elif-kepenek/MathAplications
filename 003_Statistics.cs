namespace MathAplications
{
    public class Statistics {
        /// <summary>
        /// Girilen sayı kadar elamanlı 1-100 arasındaki sayılardan dizi oluşturur.
        /// </summary>
        public static void CreateData () {
            Console.WriteLine("Kaç veriden oluşacak? ");
            int limit = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[limit];

            for (int i = 0; i < limit; i++)
            {
                numbers[i] = new Random().Next(0, 100);
                Console.Write("{0, 3}", numbers[i]);
            }
            Console.WriteLine("\nDizinin en büyük elemanı: {0} \nDizinin en küçük elemanı: {1}", BiggestData(numbers), SmallestData(numbers));
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

    }
}