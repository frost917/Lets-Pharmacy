using System;
using System.Collections.Generic;

namespace Lets_Pharmacy
    {
    public static class Scripts
    {
        readonly private static Dictionary<int, string> sleepScript = new Dictionary<int, string>()
        {
            {0, "정리할 시간이 다가와 나는 방에 돌아와 침대에 누웠다." },

            {1, "이른 감이 없잖아 있지만 나름대로 피곤한 것같아 조용히 침대에 누웠다." },

            {2, "시간이 너무 늦었다. 피곤에 찌든 몸을 곧바로 침대에 던져버렸다." }
        };

        readonly private static Dictionary<int, string> failedScript = new Dictionary<int, string>()
        {
            {0, "피실험자는 죽었다." +
                "/n피실험자의 [데이터 말소]." },

            {1, "다행히도 피실험자는 살아있다." +
                "/n전신이 [데이터 말소]./n" +
                "과연 이걸 살아있다고 해야할지는 의문이군." }
        };

        readonly private static Dictionary<int, string> medMakingScript = new Dictionary<int, string>()
        {
            {0, "첫 작업이네요./n하는 일은 간단하답니다./n매니저님이 결정만 하시면 부하직원들이 다 알아서 해준답니다."},
            {1, "" }
        };


        public static Dictionary<int, string> SleepScript => sleepScript;
        public static Dictionary<int, string> FailedScript => failedScript;
        public static Dictionary<int, string> MedMakingScript => medMakingScript;
    }
}
