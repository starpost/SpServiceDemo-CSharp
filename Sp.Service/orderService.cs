using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sp.Entity;
using System.Web;

namespace Sp.Service
{
    public class orderService
    {
 


        public string CreateOrder(List<OrderEntity> OrderList)
        {            

            SpServiceReference.SpServiceClient sp = new SpServiceReference.SpServiceClient();
            string _OrderStr = GetOrderXml(OrderList);//获取订单的xml数据
            return sp.orderService(_OrderStr, CommonService.GetVerifyCode(_OrderStr));
             
        }


        /// <summary>
        /// 拼接订单xml数据
        /// </summary>
        /// <param name="OrderList">订单List</param>
        /// <returns></returns>
        private string GetOrderXml(List<OrderEntity> OrderList)
        {
            StringBuilder _result = new StringBuilder();

            _result.Append("<Request lang=\"zh-CN\">");
            _result.Append("<Body>");
            foreach (OrderEntity Order in OrderList)
            {
                
                _result.Append("<Order ");

                _result.Append("ref_number=\"").Append(Order.Ref_number).Append("\" ");
                _result.Append("express_code=\"").Append(Order.Express_code).Append("\" ");
                _result.Append("buyer_id=\"").Append(Order.Buyer_id).Append("\" ");
                _result.Append("buyer_email=\"").Append(Order.Buyer_email).Append("\" ");
                _result.Append("insurance_sign=\"").Append(Order.Insurance_sign).Append("\" ");
                _result.Append("insurance_amount=\"").Append(Order.Insurance_amount).Append("\" ");
                _result.Append("goods_type=\"").Append(Order.Goods_type).Append("\" ");
                _result.Append("parcel_type=\"").Append(Order.Parcel_type).Append("\" ");
                _result.Append("currency=\"").Append(Order.Currency).Append("\" ");
                _result.Append("return_sign=\"").Append(Order.Return_sign).Append("\" ");
                _result.Append("remark=\"").Append(Order.Remark).Append("\" ");
                _result.Append("operate_flag=\"").Append(Order.Operate_flag).Append("\" ");
                _result.Append("d_company=\"").Append(Order.D_company).Append("\" ");                                
                _result.Append("d_contact=\"").Append(Order.D_contact).Append("\" ");
                _result.Append("d_tel=\"").Append(Order.D_tel).Append("\" ");
                _result.Append("d_mobile=\"").Append(Order.D_mobile).Append("\" ");
                _result.Append("d_email=\"").Append(Order.D_email).Append("\" ");
                _result.Append("d_address=\"").Append(Order.D_address).Append("\" ");
                _result.Append("d_country=\"").Append(Order.D_country).Append("\" ");
                _result.Append("d_province=\"").Append(Order.D_province).Append("\" ");
                _result.Append("d_city=\"").Append(Order.D_city).Append("\" ");                
                _result.Append("d_post_code=\"").Append(Order.D_post_code).Append("\" ");

                _result.Append("cargo_total_value=\"").Append(Order.Cargo_total_value).Append("\" ");

                _result.Append(">");

                foreach (CargoEntity Cargo in Order.Cargo)
                {
                    _result.Append("<Cargo ");
                        _result.Append("oc_hscode=\"").Append(Cargo.Oc_hscode).Append("\" ");
                        _result.Append("oc_name_en=\"").Append(Cargo.Oc_name_en).Append("\" ");
                        _result.Append("oc_name_cn=\"").Append(Cargo.Oc_name_cn).Append("\" ");
                        _result.Append("oc_quantity=\"").Append(Cargo.Oc_quantity).Append("\" ");
                        _result.Append("oc_sku=\"").Append(Cargo.Oc_sku).Append("\" ");
                        _result.Append("oc_value=\"").Append(Cargo.Oc_value).Append("\" ");
                        _result.Append("oc_weight=\"").Append(Cargo.Oc_weight).Append("\" ");
                        _result.Append("oc_remark=\"").Append(Cargo.Oc_remark).Append("\" ");
                    _result.Append("/>");
                }

                _result.Append("</Order>");
            }
            _result.Append("</Body>");
            _result.Append("<Head>" + System.Configuration.ConfigurationSettings.AppSettings["UserID"].ToString() + "</Head>");
            _result.Append("</Request>");

            return _result.ToString();
        }
    }
}
