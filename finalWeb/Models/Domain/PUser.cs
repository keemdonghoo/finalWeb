namespace finalWeb.Models.Domain
{
    public class PUser
    {
        public long Id { get; set; }

        public string PUser_id { get; set; }  // 유저 아이디

        public string PUser_password { get; set; } // 유저 패스워드

        public string PUser_name { get; set; } // 유저 이름

        public string PUser_phoneNum { get; set; } // 유저 핸드폰번호
    }
}
