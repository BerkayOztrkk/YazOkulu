using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dene;
using DataAccesLayer;
using BusinessLogicLayer;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityOgrenci ent=new EntityOgrenci();
        ent.Ad=TextBox1.Text;
        ent.Soyad=TextBox2.Text;
        ent.Numara=TextBox3.Text;
        ent.Sifre=TextBox4.Text;
        ent.Fotograf=TextBox5.Text;
        BLLogrenci.OgrenciEkleBLL(ent);
        



    }
}