using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Sp.Entity
{
    public class CargoEntity
    {

        private string _oc_name_en;

        public string Oc_name_en
        {
            get { return _oc_name_en; }
            set { _oc_name_en = value; }
        }
        private string _oc_name_cn;

        public string Oc_name_cn
        {
            get { return _oc_name_cn; }
            set { _oc_name_cn = value; }
        }
        private decimal _oc_weight;

        public decimal Oc_weight
        {
            get { return _oc_weight; }
            set { _oc_weight = value; }
        }
        private int _oc_quantity;

        public int Oc_quantity
        {
            get { return _oc_quantity; }
            set { _oc_quantity = value; }
        }
        private decimal _oc_value;

        public decimal Oc_value
        {
            get { return _oc_value; }
            set { _oc_value = value; }
        }
        private string _oc_hscode;

        public string Oc_hscode
        {
            get { return _oc_hscode; }
            set { _oc_hscode = value; }
        }
        private string _oc_sku;

        public string Oc_sku
        {
            get { return _oc_sku; }
            set { _oc_sku = value; }
        }
        private string _oc_url;

        public string Oc_url
        {
            get { return _oc_url; }
            set { _oc_url = value; }
        }
        private string _oc_remark;

        public string Oc_remark
        {
            get { return _oc_remark; }
            set { _oc_remark = value; }
        }


    }
}
