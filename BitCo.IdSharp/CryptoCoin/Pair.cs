using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BitCo.IdSharp.CryptoCoin
{
    public enum Pair
    {
        [DescriptionAttribute("btc_idr")] BTCxIDR = 1,
        [DescriptionAttribute("eth_btc")] ETHxBTC = 2,
        [DescriptionAttribute("eth_idr")] ETHxIDR = 3,
        [DescriptionAttribute("bch_idr")] BCHxIDR = 4,
        [DescriptionAttribute("etc_idr")] ETCxIDR = 5,
        [DescriptionAttribute("bts_btc")] BTSxBTC = 6,
        [DescriptionAttribute("drk_btc")] DASHxBTC = 7,
        [DescriptionAttribute("doge_btc")] DOGExBTC = 8,
        [DescriptionAttribute("ltc_btc")] LTCxBTC = 9,
        [DescriptionAttribute("nxt_btc")] NXTxBTC = 10,
        [DescriptionAttribute("str_btc")] XLMxBTC = 11,
        [DescriptionAttribute("nem_btc")] XEMxBTC = 12,
        [DescriptionAttribute("xrp_btc")] XRP_BTC = 13,
    }

    public class EnumUtils
    {
        public static string stringValueOf(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes.Length > 0)
            {
                return attributes[0].Description;
            }
            else
            {
                return value.ToString();
            }
        }

        public static object enumValueOf(string value, Type enumType)
        {
            string[] names = Enum.GetNames(enumType);
            foreach (string name in names)
            {
                if (stringValueOf((Enum)Enum.Parse(enumType, name)).Equals(value))
                {
                    return Enum.Parse(enumType, name);
                }
            }

            throw new ArgumentException("The string is not a description or value of the specified enum.");
        }
    }
}
