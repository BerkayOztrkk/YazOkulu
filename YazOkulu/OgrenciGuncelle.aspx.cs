using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dene;
using DataAccesLayer;
using BusinessLogicLayer;


public partial class OgrenciGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt32(Request.QueryString["Id"]);
        id.Text = x.ToString();
        id.Enabled = false;
        if (Page.IsPostBack==false)
        {

            List<EntityOgrenci> Ogrlist = BLLogrenci.BllDetay(x);
            txtad.Text=Ogrlist[0].Ad.ToString();
            txtsoyad.Text=Ogrlist[0].Soyad.ToString();
            txtno.Text=Ogrlist[0].Numara.ToString();
            txtsifre.Text=Ogrlist[0].Sifre.ToString();
            txtfoto.Text=Ogrlist[0].Fotograf.ToString();
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityOgrenci ent = new EntityOgrenci();
      txtad.Text = ent.Ad.ToString();
      txtsoyad.Text = ent.Soyad.ToString();
      txtno.Text = ent.Numara.ToString();
      txtsifre.Text = ent.Sifre.ToString();
      txtfoto.Text = ent.Fotograf.ToString();
      id.Text = Convert.ToInt32( ent.Id).ToString();
        
        ent.Id=Convert.ToInt32(txtad.Text);
        BLLogrenci.OgrenciGuncelleBLL(ent);
        Response.Redirect("OgrenciListesi.aspx");


    }
}