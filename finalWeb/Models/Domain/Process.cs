namespace finalWeb.Models.Domain
{
    public class Process
    {
        public long Id { get; set; }

        public string Process_name { get; set; } // 공정이름

        public bool Process_status { get; set; } // 공정 상태

        public bool? Process_checkRight { get; set; } // 공정 검사 통과 여부
    }
}
