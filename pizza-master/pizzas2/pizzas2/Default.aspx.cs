using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace pizzas2
{
    public partial class Default : Page
    {

       protected void Page_Load(object sender,EventArgs e)
        {
            Calorias();
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {//en este metodo agregamos los ingredientes a la lista1
            Ingrediente i = new Ingrediente(this.txtNombre.Text, Convert.ToInt32(txtCalorias.Text));
            lista1.Items.Add(i.nombre);
            Globales.arr.Add(i);

        }
        protected void BtnPasar_Click(object sender, EventArgs e)
        //en este metodo pasamos de lista1 a lista2 
        {       //Ingrediente i  lista1.SelectedItem;
                int ind = lista1.SelectedIndex;//guardamos lo seleccionado en la variable ind
            lista2.Items.Add(Globales.arr[ind].ToString());//pasamos ind a la lista2 
            Ingrediente aux = (pizzas2.Ingrediente)Globales.arr[ind];
            Globales.cal.Add(aux);
            Calorias();//mandamos a llamar a calorias
        }

        protected void BtnQuitar_Click(object sender,EventArgs e)
        {
            int ind = lista2.SelectedIndex;//guardamos en aux el elemento seleccionado
            lista2.Items.Remove(Globales.cal[ind].ToString());//eliminamos el elemento seleccionado en la lista2

            Globales.cal.RemoveAt(ind);
            //Resta(Convert.ToInt32(totalCalorias));
            Calorias();

        }

        protected void Calorias()
        //en este metodo realizaremos el calculo de las calorias
        {   
            int suma = 0;

            foreach (Ingrediente i in Globales.cal)
            {
                suma += i.calorias;
            }

            totalCalorias.Text = suma.ToString();
           

        }

        






    }
}
