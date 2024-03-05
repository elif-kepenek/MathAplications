namespace MathAplications
{
    public class Circle {
        public const double pi = 3.14;

        /// <summary>
        /// Parametre olarak yarıçapı girilen çemberin çevresini hesaplar.
        /// </summary>
        /// <param name="r">Yarıçap</param>
        /// <returns>Çemberin çevresi</returns>
        public static double PerimeterOfCircle (double r) {
            return 2 * pi * r;
        }
    }
}