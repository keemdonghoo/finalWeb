﻿namespace finalWeb.Models.Domain
{
    public class Order
    {
        public long Id { get; set; }    // PK

        public Item? Item { get; set; }

        public DateTime? Order_startDate { get; set; } // 주문 들어온 날짜

        public DateTime? Order_endDate { get; set; } // 주문 마감 날짜

        public DateTime? Order_sendDate { get; set; } // 주문 출고 날짜

        public string Order_status { get; set; } // 주문 진행 상태

        public string? Order_name { get; set; } // 주문 이름

        public long Order_count { get; set; } // 주문 수량

        public string Order_account { get; set; }  // 거래처
    }
}
