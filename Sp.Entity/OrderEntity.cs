using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using System.Collections.Generic;

namespace Sp.Entity
{
    public class OrderEntity
    {
        private string _ref_number;

        public string Ref_number
        {
            get { return _ref_number; }
            set { _ref_number = value; }
        }
        private string _order_number;

        public string Order_number
        {
            get { return _order_number; }
            set { _order_number = value; }
        }
        private string _tracking_number;

        public string Tracking_number
        {
            get { return _tracking_number; }
            set { _tracking_number = value; }
        }
        private string _express_code;

        public string Express_code
        {
            get { return _express_code; }
            set { _express_code = value; }
        }
        private string _buyer_id;

        public string Buyer_id
        {
            get { return _buyer_id; }
            set { _buyer_id = value; }
        }
        private string _buyer_email;

        public string Buyer_email
        {
            get { return _buyer_email; }
            set { _buyer_email = value; }
        }
        private int _insurance_sign;

        public int Insurance_sign
        {
            get { return _insurance_sign; }
            set { _insurance_sign = value; }
        }
        private decimal _insurance_amount;

        public decimal Insurance_amount
        {
            get { return _insurance_amount; }
            set { _insurance_amount = value; }
        }
        private string _goods_type;

        public string Goods_type
        {
            get { return _goods_type; }
            set { _goods_type = value; }
        }
        private string _parcel_type;

        public string Parcel_type
        {
            get { return _parcel_type; }
            set { _parcel_type = value; }
        }
        private string _currency;

        public string Currency
        {
            get { return _currency; }
            set { _currency = value; }
        }
        private int _return_sign;

        public int Return_sign
        {
            get { return _return_sign; }
            set { _return_sign = value; }
        }
        private string _remark;

        public string Remark
        {
            get { return _remark; }
            set { _remark = value; }
        }
        private int _operate_flag;

        public int Operate_flag
        {
            get { return _operate_flag; }
            set { _operate_flag = value; }
        }

        private string _j_company;

        public string J_company
        {
            get { return _j_company; }
            set { _j_company = value; }
        }
        private string _j_contact;

        public string J_contact
        {
            get { return _j_contact; }
            set { _j_contact = value; }
        }
        private string _j_tel;

        public string J_tel
        {
            get { return _j_tel; }
            set { _j_tel = value; }
        }
        private string _j_mobile;

        public string J_mobile
        {
            get { return _j_mobile; }
            set { _j_mobile = value; }
        }
        private string _j_email;

        public string J_email
        {
            get { return _j_email; }
            set { _j_email = value; }
        }
        private string _j_address;

        public string J_address
        {
            get { return _j_address; }
            set { _j_address = value; }
        }
        private string _j_province;

        public string J_province
        {
            get { return _j_province; }
            set { _j_province = value; }
        }
        private string _j_city;

        public string J_city
        {
            get { return _j_city; }
            set { _j_city = value; }
        }
        private string _j_post_code;

        public string J_post_code
        {
            get { return _j_post_code; }
            set { _j_post_code = value; }
        }

        private string _d_company;

        public string D_company
        {
            get { return _d_company; }
            set { _d_company = value; }
        }
        private string _d_contact;

        public string D_contact
        {
            get { return _d_contact; }
            set { _d_contact = value; }
        }
        private string _d_tel;

        public string D_tel
        {
            get { return _d_tel; }
            set { _d_tel = value; }
        }
        private string _d_mobile;

        public string D_mobile
        {
            get { return _d_mobile; }
            set { _d_mobile = value; }
        }
        private string _d_email;

        public string D_email
        {
            get { return _d_email; }
            set { _d_email = value; }
        }
        private string _d_address;

        public string D_address
        {
            get { return _d_address; }
            set { _d_address = value; }
        }
        private string _d_country;

        public string D_country
        {
            get { return _d_country; }
            set { _d_country = value; }
        }
        private string _d_province;

        public string D_province
        {
            get { return _d_province; }
            set { _d_province = value; }
        }
        private string _d_city;

        public string D_city
        {
            get { return _d_city; }
            set { _d_city = value; }
        }
        private string _d_post_code;

        public string D_post_code
        {
            get { return _d_post_code; }
            set { _d_post_code = value; }
        }
        private List<CargoEntity> _Cargo;

        public List<CargoEntity> Cargo
        {
            get { return _Cargo; }
            set { _Cargo = value; }
        }

        private decimal _cargo_total_value;

        public decimal Cargo_total_value
        {
            get { return _cargo_total_value; }
            set { _cargo_total_value = value; }
        }
    }
}
