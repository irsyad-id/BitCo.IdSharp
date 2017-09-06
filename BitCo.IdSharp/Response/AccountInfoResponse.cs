using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCo.IdSharp.Response
{
    public class Balance
    {
        public int idr { get; set; }
        public string btc { get; set; }
        public string bch { get; set; }
        public string bts { get; set; }
        public string drk { get; set; }
        public string doge { get; set; }
        public string eth { get; set; }
        public string etc { get; set; }
        public string ltc { get; set; }
        public string nxt { get; set; }
        public string nem { get; set; }
        public string str { get; set; }
        public string xrp { get; set; }
    }

    public class BalanceHold
    {
        public int idr { get; set; }
        public string btc { get; set; }
        public string bch { get; set; }
        public string bts { get; set; }
        public string drk { get; set; }
        public string doge { get; set; }
        public string eth { get; set; }
        public string etc { get; set; }
        public string ltc { get; set; }
        public string nxt { get; set; }
        public string nem { get; set; }
        public string str { get; set; }
        public string xrp { get; set; }
    }

    public class Address
    {
        public string btc { get; set; }
        public string bch { get; set; }
        public string bts { get; set; }
        public string drk { get; set; }
        public string doge { get; set; }
        public string eth { get; set; }
        public string etc { get; set; }
        public string ltc { get; set; }
        public string nxt { get; set; }
        public string nem { get; set; }
        public string str { get; set; }
        public string xrp { get; set; }
    }

    public class Return
    {
        public Balance balance { get; set; }
        public BalanceHold balance_hold { get; set; }
        public Address address { get; set; }
        public string user_id { get; set; }
        public string profile_picture { get; set; }
        public string name { get; set; }
        public int server_time { get; set; }
        public string email { get; set; }
    }

    public class AccountInfoResponse
    {
        public int success { get; set; }
        public Return @return { get; set; }
        public string error { set; get; }
    }
}
