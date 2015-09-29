using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.IO;
using System.Xml;
using System.Collections.Generic;

namespace SpServiceDemo
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

 


            List<Sp.Entity.CargoEntity> CargoList = new List<Sp.Entity.CargoEntity>();
            Sp.Entity.CargoEntity Cargo = new Sp.Entity.CargoEntity();
            Cargo.Oc_name_en = "iphone5";
            Cargo.Oc_quantity = 1;
            Cargo.Oc_value = 1;
            Cargo.Oc_hscode = "IP100005";
            Cargo.Oc_name_cn = "iphone 5";
            Cargo.Oc_remark = "iPhone5";
            Cargo.Oc_sku = "KU100005";
            Cargo.Oc_weight = 1;
            CargoList.Add(Cargo);

            List<Sp.Entity.OrderEntity> OrderList = new List<Sp.Entity.OrderEntity>();
            Sp.Entity.OrderEntity Order = new Sp.Entity.OrderEntity();
            Order.Cargo = CargoList;

            Order.D_email = "sp@starpost.cn";         
            Order.Ref_number = "11110001";
            Order.Express_code = "MYXBP";
            Order.Buyer_id = "ahmedasas";
            Order.Insurance_sign = 0;
            Order.Insurance_amount = 0;
            Order.Goods_type = "0";
            Order.Parcel_type = "Gift";
            Order.Currency="";
            Order.Return_sign = 0;
            Order.Remark = "";
            Order.Operate_flag = 2;
            Order.D_company = "";
            Order.D_contact = "Ahmed Asas";
            Order.D_tel = "13596323302";
            Order.D_mobile = "";
            Order.D_email = "";
            Order.D_address = "asas dairies";
            Order.D_country = "MY";
            Order.D_province = "iringa 255";
            Order.D_city = "iringa";
            Order.D_post_code = "92100";
            Order.Cargo_total_value = 1;

            OrderList.Add(Order);
          


            result.InnerText = new Sp.Service.orderService().CreateOrder(OrderList);
 
        }
         


    }
}
