namespace MathAplications
{
    public class Number
    {

        /// <summary>
        /// Parametre olarak aldığı sayının tek olup olmamasını kontrol eder.
        /// </summary>
        /// <param name="n">Sayı</param>
        /// <returns>Tek ise true değilse false</returns>
        public static bool OddNumber (int n)
        {
            if (n % 2 == 1)
            {
                return true;
            } else {
                return false;
            }
        }

        /// <summary>
        /// Parametre olarak aldığı sayının çift olup olmamasını kontrol eder.
        /// </summary>
        /// <param name="n">Sayı</param>
        /// <returns>Çift ise true değilse false</returns>
        public static bool EvenNumber (int n)
        {
            if (n % 2 == 0)
            {
                return true;
            } else {
                return false;
            }
        }
    
        /// <summary>
        /// Parametre olarak aldığı sayının mutlak değerini döner.
        /// </summary>
        /// <param name="n">Sayı</param>
        /// <returns>Mutlak değer</returns>
        public static int AbsoluteValue (int n) {
            if (n > 0)
            {
                return n;
            } else if (n < 0)
            {
                return n * (-1);                
            } else {
                return 0;
            }
        }
    }
}