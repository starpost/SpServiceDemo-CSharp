using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sp.Service
{
    public class CommonService
    {
        /// <summary>
        /// 把 MD5 编码后的数据进行 Base64 编码，字符编码为(UTF-8)，此时编码后的字符串即为 verifyCode
        /// </summary>
        /// <param name="_OrderXml">订单的xml数据</param>
        /// <returns>返回verifyCode</returns>
        public static string GetVerifyCode(string _OrderXml)
        {
            string _result = string.Empty;
            _result = System.Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(_OrderXml + System.Configuration.ConfigurationSettings.AppSettings["CheckWord"].ToString(), "MD5")));
            return _result;
        }
    }
}
