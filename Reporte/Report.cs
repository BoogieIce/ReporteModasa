using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

namespace Reporte
{
    public partial class Report : DevExpress.XtraReports.UI.XtraReport
    {
        public Report()
        {
            InitializeComponent();
        }
        public void InitDate (String orderid,DateTime orderdate, string customer, string address, string postalcode, string city, string phone, List<OrderDetail> data)
        {
            pOrderID.Value = orderid;
            pDate.Value = orderdate.Date;
            pCustomerName.Value = customer;
            pAddress.Value = address;
            pPostalCode.Value = postalcode;
            pCity.Value = city;
            pPhone.Value = phone;
            objectDataSource1.DataSource = data;
       }
    }
}
