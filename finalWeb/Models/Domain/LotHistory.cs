﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace finalWeb.Models.Domain
{
    public class LotHistory
    {
        [Key]
        public long LotHistoryId { get; set; } // 기본 키

        [ForeignKey("Lot")]
        public long LotId { get; set; }

        [ForeignKey("Process")]
        public long ProcessId { get; set; }

        public Lot Lot { get; set; }

        public Process Process { get; set; }

        public DateTime? LotHistory_Date { get; set; } // LOT 시작 날짜

        public string? LotHistory_status { get; set; } // LOT 종료 날짜
    }
}
