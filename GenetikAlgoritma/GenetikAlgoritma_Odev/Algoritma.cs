using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GenetikAlgoritma_Odev
{
    class Algoritma
    {
        int populasyon_boyutu;
        double carprazlanma_orani;
        double mutasyon_orani;
        double seckinlik_orani; //0.7 gibi
        //int jenerasyon_sayisi;
        public int jenerasyon_sayisi { get; set; }

        List<Kromozom> kromozomlar;
        List<Kromozom> yeni_nesil;
       // List<Kromozom> en_iyi_sonuclar;
        public List<Kromozom> en_iyi_sonuclar { get; set; }


        public Algoritma(int populasyon_boyutu, double carprazlanma_orani, double mutasyon_orani, double seckinlik_orani, int jenerasyon_sayisi)
        {
            this.populasyon_boyutu = populasyon_boyutu;
            this.carprazlanma_orani = carprazlanma_orani;
            this.mutasyon_orani = mutasyon_orani;
            this.seckinlik_orani = seckinlik_orani;
            this.jenerasyon_sayisi = jenerasyon_sayisi;
            kromozomlar = new List<Kromozom>();
            en_iyi_sonuclar = new List<Kromozom>();
        }

        // -10<=x,y<=10
        public double Fonksiyon(double x, double y)
        {
            return Math.Pow(Math.Sin(3 * Math.PI * x), 2) + Math.Pow((x - 1), 2) * (1 + Math.Pow(Math.Sin(3 * Math.PI * y), 2)) +
                Math.Pow((y - 1), 2) * (1 + Math.Pow(Math.Sin(2 * Math.PI * y), 2));
        }
        Random rnd = new Random();
        public double Random_Uret()
        {
            
            double min = -10.0;
            double max = 10.0;

            double random = min + (max - min) * rnd.NextDouble();

            return random;
        }

        public void genUret()
        {
            for (int i = 0; i < populasyon_boyutu; i++)
            {
                double x = Random_Uret();
                double y = Random_Uret();
                double fx = Fonksiyon(x, y);
                Kromozom kromozom = new Kromozom();
                kromozom.x = x;
                kromozom.y = y;
                kromozom.fx = fx;
                kromozomlar.Add(kromozom);
            }
        }

        List<Kromozom> secilmis_kromozomlar = new List<Kromozom>();
        public void Secme()
        {

            secilmis_kromozomlar = new List<Kromozom>();


            en_iyi_sonuclar.Add(kromozomlar.OrderBy(a => a.fx).Take(1).Single());

            yeni_nesil.AddRange(kromozomlar.OrderBy(a => a.fx).Take((int)(seckinlik_orani*populasyon_boyutu)).ToList());

            HashSet<Kromozom> yeniNesilSet = new HashSet<Kromozom>(yeni_nesil);
            kromozomlar.RemoveAll(k => yeniNesilSet.Contains(k));



            //  kromozomlar = kromozomlar.Except(yeni_nesil).ToList();

            populasyon_boyutu = kromozomlar.Count();

            while (secilmis_kromozomlar.Count < populasyon_boyutu)
            {
                //eşit olmasında sıkıntı yok
                Kromozom kromozom1 = kromozomlar[rnd.Next(populasyon_boyutu)];
                Kromozom kromozom2 = kromozomlar[rnd.Next(populasyon_boyutu)];
                secilmis_kromozomlar.Add(kromozom1.fx < kromozom2.fx ? kromozom1 : kromozom2);

            }
    
            kromozomlar =  secilmis_kromozomlar;
  
        }

        public void Carprazlama()
        {
   

            for (int i = 0; i < carprazlanma_orani * populasyon_boyutu; i++)
            {
                double alfa = rnd.NextDouble();
                int rnd1 = rnd.Next(0, populasyon_boyutu);
                int rnd2 = rnd.Next(0, populasyon_boyutu);

                Kromozom kromozom1 = kromozomlar[rnd1];

                Kromozom kromozom2 = kromozomlar[rnd2];

                // >0.5 ise y genini al
                if (rnd.Next() > 0.5)
                {
                    double geciciy = kromozom1.y;
                    kromozom1.y = (1 - alfa) * kromozom1.y + alfa * kromozom2.y;
                    kromozom2.y = (1 - alfa) * kromozom2.y + alfa * geciciy;
                    //y
                }
                else
                {
                    double gecicix = kromozom1.x;
                    kromozom1.x = (1 - alfa) * kromozom1.x + alfa * kromozom2.x;
                    kromozom2.x = (1 - alfa) * kromozom2.x + alfa * gecicix;
                    //x
                }

                kromozom1.fx = Fonksiyon(kromozom1.x, kromozom1.y);
                kromozom2.fx = Fonksiyon(kromozom2.x, kromozom2.y);

                kromozomlar[rnd1] = kromozom1;
                kromozomlar[rnd2] = kromozom2;


            }

        }


        public void Mutasyon()
        {
           // Random random = new Random();

            for (int i = 0; i < populasyon_boyutu; i++)
            {
                double px = rnd.NextDouble();
                double py = rnd.NextDouble();
                Kromozom kromozom = kromozomlar[i];

                if (px < mutasyon_orani)
                    kromozom.x = (rnd.NextDouble() * 20) - 10; 
                if (py < mutasyon_orani)
                    kromozom.y = (rnd.NextDouble() * 20) - 10;

                kromozom.fx = Fonksiyon(kromozom.x, kromozom.y);

                kromozomlar[i] = kromozom;

            }
            
        }

        public void Calistir()
        {
            
            genUret();

            for (int jenerasyon = 0; jenerasyon < jenerasyon_sayisi; jenerasyon++)
            {
                yeni_nesil = new List<Kromozom>();

             
                
                Secme();

               
                Carprazlama();

                
                Mutasyon();

              
                Console.WriteLine($"Jenerasyon {jenerasyon + 1} tamamlandı. En iyi sonuç: {en_iyi_sonuclar.Last().fx}");

              
                kromozomlar.AddRange(yeni_nesil);
                populasyon_boyutu = kromozomlar.Count();

            }

          
          /*  Console.WriteLine("Sonuçlar:");
            foreach (var kromozom in en_iyi_sonuclar)
            {
                Console.WriteLine($"x: {kromozom.x}, y: {kromozom.y}, f(x,y): {kromozom.fx}");
            }
          */
        }


    }
}
