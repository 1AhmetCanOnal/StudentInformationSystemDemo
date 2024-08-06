using Business.Abstract;
using DataAccess.Concrete.EntitiyFramework.Context;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Filtering.Templates;
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

namespace StudentUI
{
    public partial class XtraAddStudent : DevExpress.XtraEditors.XtraForm
    {
        private readonly IStudentService _studentService;
        int _id;


        public XtraAddStudent(IStudentService studentService)
        {
            InitializeComponent();
            _studentService = studentService;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(btnClose.Text=="Vazgeç")
            {
                Clear();               
            }
            else
            {
                this.Close();
            }
           
        }

        private void XtraAddStudent_Load(object sender, EventArgs e)
        {
            GetList();
            /* Test Amaçlıdır 
             StudentDbContext context = new StudentDbContext();
             var result =context.Students.ToList();
             gridControl1.DataSource = result;
            */

        }
        void GetList()
        {
            var result = _studentService.GetList();
            gC1.DataSource = result;
        }
        void Clear()
        {
            textStudentName.Text = string.Empty;
            textStudentSurname.Text = string.Empty;
            textStudentDep.Text = string.Empty;
            btnClose.Text = "Kapat";
            btnSave.Text = "Kaydet";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Güncelleme işlemidir.
            if(btnSave.Text=="Güncelle")
            {
                var fintStudent = _studentService.Get(_id);
                fintStudent.Name = textStudentName.Text;
                fintStudent.Surname = textStudentSurname.Text;
                fintStudent.Department = textStudentDep.Text;
                fintStudent.Dateofbirth = dateStudentBD.Value;

                var result = _studentService.Update(fintStudent);
                if(result)
                {
                    XtraMessageBox.Show("Güncelleme Başarıldır.", "Başarılı", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    GetList();
                    Clear();
                  

                }
                

            }else {
                //Kaydet İşlemidir.
                if (textStudentName.Text !="" && textStudentSurname.Text !="" && textStudentDep.Text !="")
                {
                    Student student = new Student
                    {
                        Name = textStudentName.Text,
                        Surname = textStudentSurname.Text,
                        Department = textStudentDep.Text,
                        Dateofbirth = dateStudentBD.Value
                        // Dateofbirth = DateTime.TryParse(dateStudentBD.Value.ToString)

                    };
                    var result = _studentService.Add(student);
                    if (result)
                    {
                        MessageBox.Show("Öğrenci Ekleme İşlemi Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetList();
                        Clear();

                    }
                    else
                    {
                        MessageBox.Show("Bir Hata ile Karşılaşıldı !", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else
                {
                    MessageBox.Show("Veriler Boş Geçilemez", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              
            }
          

        }

        private void repositoryBtnDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show($"{(gridView1.GetFocusedRow() as Student).Name}Adlı Kişiyi Silmek istiyor musunuz ? ",
                "Sil?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var student = (gridView1.GetFocusedRow() as Student);
                _studentService.Delete(student);
                GetList();
            }
            else
            {

            }
        }

        private void repositoryBtnEdit_Click(object sender, EventArgs e)
        {
            _id = (gridView1.GetFocusedRow() as Student).Id;
            string name = (gridView1.GetFocusedRow() as Student).Name;
            string surname = (gridView1.GetFocusedRow() as Student).Surname;
            string deparment = (gridView1.GetFocusedRow() as Student).Department;
            DateTime dob = (gridView1.GetFocusedRow() as Student).Dateofbirth;

            textStudentName.Text = name;
            textStudentSurname.Text = surname;
            textStudentDep.Text= deparment;
            dateStudentBD.Value = dob;

            btnSave.Text ="Güncelle";
            btnClose.Text = "Vazgeç";
        }
    }
}