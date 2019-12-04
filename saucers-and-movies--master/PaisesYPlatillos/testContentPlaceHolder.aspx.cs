using System;
using System.Web;
using System.Web.UI;
using System.Data;
using PaisesYPlatillos.Controllers;
using PaisesYPlatillos.Models;

namespace PaisesYPlatillos
{
    public partial class testContentPlaceHolder : System.Web.UI.Page
    {
    private CountriesController controller;
    private SaucersController saucersController;

    public testContentPlaceHolder()
    {
        this.controller = new CountriesController();
        this.saucersController = new SaucersController();
    }

    protected void Page_Load(object sender, EventArgs e)
    {

        this.Grid.DataSource = this.saucersController.GetList();

        /*
        DataSet dts = new DataSet();
        dts.ReadXml("/Users/pamelaruizhernandez/Projects/PaisesYPlatillos/PaisesYPlatillos/EmptyXmlFile.xml");
        this.Grid.DataSource = dts.Tables[0];
        */
        DataBind();

        int i = 0;
        foreach (Country c in this.controller.GetList())
        {
            this.cboPais.Items.Add(c.Name);
            this.cboPais.Items[i].Text = c.Name;
            this.cboPais.Items[i].Value = c.Id.ToString();
            i++;
        }

        /*
        this.cboPais.Items.Add("China");//DropDownLis en Default.aspx
        this.cboPais.Items.Add("México");
        this.cboPais.Items.Add("EUA");
        this.cboPais.Items.Add("España");
        this.cboPais.Items.Add("Brasil");
        */


    }
}
}

