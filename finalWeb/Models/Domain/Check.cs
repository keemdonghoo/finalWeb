using System.Diagnostics;

namespace finalWeb.Models.Domain
{
    public class Check
    {
        public long Id { get; set; } // PK

        public Process? Process { get; set; }

        public string Check_item { get; set; } // 검사 항목

        public string Check_value { get; set; } // 검사 기준 값
    }
}
