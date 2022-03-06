using System;

namespace odev1
{
    class Program
    {
        static void Main(string[] args){
            
            /*

            4.soru
            
            string cumle;
            cumle=Convert.ToString(Console.ReadLine());

            string[] kelimeler=cumle.Split(" ");
            int kelimeSayisi=kelimeler.Length;
            Console.WriteLine(kelimeSayisi);
            char[] karakterler=cumle.ToCharArray();
            int count=0;
            foreach (var item in karakterler)
            {
                if(item==' '){
                    count++;
                }
            }

            Console.WriteLine(karakterler.Length-count);
            */


            /*

            3.soru

            Console.WriteLine("Lutfen bir sayi giriniz ");
            int sayi;
            sayi=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lutfen kelimeleri giriniz ");
            string[] kelimeler=new string[sayi];
            try
            {
                for (int i = 0; i < sayi; i++)
            {
                kelimeler[i]=Convert.ToString(Console.ReadLine());
            }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Hata : "+ex.Message.ToString());
            }
            finally{
                Console.WriteLine("Islem tamamladi..");
            }

            Array.Reverse(kelimeler);

            foreach (var item in kelimeler)
            {
                Console.WriteLine(item);
                
            }
            */
            



            /*

            2.soru

            int n,m;
            Console.WriteLine("Lutfen 2 sayi giriniz : ");
            n=Convert.ToInt32(Console.ReadLine());
            m=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lutfen {0} adet dizi sayisini giriniz",n);

            int[] sayilar =new int[n];

            for(int i=0;i<n;i++){
                Console.WriteLine("{0}. sayi :",i+1);
                sayilar[i]=Convert.ToInt32(Console.ReadLine());    
            }
            Console.WriteLine("\n\n\n");
            foreach (var item in sayilar)
            {
                if((item==m) || (item%m==0)){
                    Console.WriteLine(item);
                }
                
            }*/







            /*

            1.soru
            
            Console.WriteLine("Lutfen pozitif bir sayi giriniz : ");
            int sayi=Convert.ToInt32(Console.ReadLine());

            int[] sayilar =new int[sayi];
            Console.WriteLine("Lutfen diziye atancak sayilari giriniz ");
            for(int i=0;i<sayi;i++){
                Console.WriteLine(i+1 + ". sayi ");
                sayilar[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\n\n");
            foreach (var item in sayilar)
            {
                if(item%2==0){
                    Console.WriteLine(item);
                }
            }*/



        }
    }
}
