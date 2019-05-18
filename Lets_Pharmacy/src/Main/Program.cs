using System;
using System.Timers;
using System.Collections.Generic;
using Lets_Pharmacy;

namespace Lets_Pharmacy
{
    public static partial class Program
    {
        static bool isWorking = false, MakingComplete = false;
        static int MakingCount = 0;
        static DateTime NowDate = new DateTime(2016, 1, 1);
        static Money_Management money = new Money_Management();
        static Medicine_Calculator med = new Medicine_Calculator();
        static Timer Days = new Timer();
        static void Main()
        {
            bool GameOver = false;
            Staff_Management staff = new Staff_Management();
            List<Medicine_Data> Made_Meds = new List<Medicine_Data>();

            Days.Interval = 24 * 1000; // second * ms
            Days.Elapsed += Days_Elapsed;

            SetStart();

            while (!GameOver)
            {
                int num = 0;

                if(MakingComplete)
                {
                    Console.WriteLine("약이 완성되었습니다.");
                    Console.WriteLine("이름을 정해주시겠어요 매니저님?");
                    med.Name = Console.ReadLine();

                    Console.WriteLine("{0}...좋은 이름이네요.", med.Name);
                    Console.WriteLine("이제 남은건 임상실험 뿐이네요. 좋은 결과가 나오길 빌죠.");
                    Console.WriteLine("임상실험 결과는 7일 뒤에 나온답니다.");
                    Console.WriteLine("그동안 편히 쉬세요.");

                    Days.Stop();
                    MakingComplete = false;
                }

                MainCUI();
                Controler.CursorPositionX(ref num);
                switch (num)
                {
                    case 0: //직원 관리
                    {
                        Console.Clear();

                        Console.WriteLine("----- 직원 관리 -----");
                        Console.WriteLine("직원 고용  해고");
                        Controler.CursorPositionX(ref num);

                        switch (num)
                        {
                            case 0: //직원 고용
                            {
                                staff.Hire(Nothired, Hired);
                                break;
                            }
                            case 1: //해고
                            {
                                staff.Fire(Nothired, Hired);
                                break;
                            }
                        }

                        break;
                    }
                    case 1: //작업 관리
                    {
                        Console.Clear();
                        Console.WriteLine("----- 작업 관리 -----");
                        Console.WriteLine("제조 시작  진행 상황");

                        if (Controler.CursorPositionX(ref num) == false)
                        {
                            Console.WriteLine("취소되었습니다.");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }

                        switch (num)
                        {
                            case 0: //제약
                            {
                                Console.Clear();
                                
                                Console.WriteLine();

                                Console.WriteLine("약재를 선택해 주세요.");

                                for(int i = 0;i<Materials.Count;i++)
                                {
                                    Console.WriteLine(" 이름: {0}, 가격: {1}", Materials[i].Name, Materials[i].Price);
                                    Console.WriteLine("정보: {0}", Materials[i].Info);
                                    Console.WriteLine();
                                }
                                Controler.CursorPositionY(ref num);

                                Console.WriteLine("작업을 개시합니다. 매일 {0}만원씩 빠져나갑니다.", Materials[num].Price);
                                Console.ReadLine();
                                Console.Clear();


                                Days.Start();
                                isWorking = true;
                                med.Id = num;
                                break;
                            }
                            case 1: //진행 상황
                            {
                                Console.Clear();

                                if(isWorking == true)
                                {
                                    Days.Stop();
                                    Console.WriteLine("아직 약을 만들고있습니다.");
                                    Console.WriteLine("...얼마나 진행됐는지 알고싶으시다고요?");
                                    Console.WriteLine("약효는 {0}정도, 안정성은 {1}정도네요.", med.Effect, med.Stability);
                                    Console.ReadLine();
                                    Console.Clear();
                                }

                                break;
                            }
                        }
                        break;
                    }
                    case 2: //자러가기
                    {
                        Sleeping(ref NowDate);
                        break;
                    }
                }
            }
        }

        private static void Days_Elapsed(object sender, ElapsedEventArgs e)
        {
            med.Making(Hired);

            if(MakingCount == 30)
            {
                isWorking = false;
                MakingComplete = true;
                MakingCount = 0;
                Days.Stop();
            }
        }
    }
}
