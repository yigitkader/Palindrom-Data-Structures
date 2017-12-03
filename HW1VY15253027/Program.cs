// Recep Yiğit Kader - 15253027

using System;

namespace HW1VY15253027
{
    class MainClass
    {
        public static void Main(string[] args)
        {
        
            Operations<string> op = new Operations<string>();
			#region Kullanıcıdan Giris Alma
			Console.WriteLine("Metin Giriniz ");
            Console.WriteLine();

            //string gelenMetin = "alyarısını sırayla";
            string gelenMetin = Console.ReadLine();
			string metin3 = op.InnerTrim(gelenMetin);
			string metin2 = op.InnerTrim2(metin3);
			string metin = op.InnerTrim3(metin2);
            #endregion

            

            MyStack<string> stk = new MyStack<string>(metin.Length);
            MyQueue<string> que = new MyQueue<string>(metin.Length);
			

          
            int sayac1 = 0;
            int sayac2 = 0;
            //char degisken;

            if (!string.IsNullOrEmpty(metin) && !string.IsNullOrWhiteSpace(metin))
            {
				while (!stk.isFull())
				{
					stk.push(metin[sayac1].ToString());
					sayac1++;
				}

				while (!que.isFull())
				{
					que.enqueue(metin[sayac2].ToString());

					sayac2++;
				}

				int degisken = 0;
				while (!stk.isEmpty() && !que.isEmpty())
				{
					if (stk.pop() == que.dequeue())
					{
						degisken++;
					}


				}

				if (degisken == metin.Length)
				{
					Console.WriteLine(" Palindromdur ");

				}
				else
				{
					Console.WriteLine(" Palindrom Degildir ");
				}
            }

            else
            {
                Console.WriteLine("Girdiginiz metinde hata vardır!!");
            }
           

            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();



        }

        }
    }

