using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Sp.Entity
{
    public class OrderResponseEntity
    {
        private string _order_number;

        public string Order_number
        {
            get { return _order_number; }
            set { _order_number = value; }
        }
        private string _ref_number;

        public string Ref_number
        {
            get { return _ref_number; }
            set { _ref_number = value; }
        }
        private string _tracking_number;

        public string Tracking_number
        {
            get { return _tracking_number; }
            set { _tracking_number = value; }
        }
        private string _OrderResponse;

        public string OrderResponse
        {
            get { return _OrderResponse; }
            set { _OrderResponse = value; }
        }

        private string _ERROR;

        public string ERROR
        {
            get { return _ERROR; }
            set { _ERROR = value; }
        }
    }
}
