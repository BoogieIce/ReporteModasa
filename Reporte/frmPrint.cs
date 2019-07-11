using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Reporte
{
    public partial class frmPrint : DevExpress.XtraEditors.XtraForm
    {
        public frmPrint()
        {
            InitializeComponent();
        }

        public void Print(Orders order, List<OrderDetail> data)
        {
            
                Report report = new Report();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                p.Visible = false;
            report.InitDate(order.OrderID.ToString(), order.OrderDate, order.ContacName, order.Address, order.Postalcode, order.City, order.Phone, data);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }
     
    }
}