using Business.Abstract;
using DevExpress.XtraEditors;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 Olacak katmanlar
    * UI katmanı
    * Entities table class
    * Dataacces context db crud
    * business
  */

namespace StudentUI
{
    public partial class XtraHome : DevExpress.XtraEditors.XtraForm
    {
        private readonly IStudentService _studentService;
        public XtraHome(IStudentService studentService)
        {
            InitializeComponent();
            _studentService = studentService;
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnAddStudent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //addStude uı ismidir.
            XtraAddStudent student;
            student = new XtraAddStudent(_studentService);
            student.MdiParent = this;
            student.Show();
        }

        private void XtraHome_Load(object sender, EventArgs e)
        {
          

        }

        private void brnStudent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
           

        }
    }
}