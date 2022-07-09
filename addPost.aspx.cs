using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using kolokwium_.Api;
using kolokwium_.Mapping;

namespace kolokwium_
{
    public partial class addPost : System.Web.UI.Page
    {
        /// <summary>
        /// Metoda ładowania strony - jeśli nie ma bazy danych to wyrzuci exception przy NHibernate.
        /// Aby sprawdzic dzialanie strony bez bady danych należy zakomentować linię 25
        /// czyli inicjalizację pobrania z bazy danych wartości do wypełnienia DropDownList.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitPost();
                InitTypePost(); //zakomentowane ponieważ nie ma bazy danych, a przy inicjalizacji strony jest używane połączenie z bazą do wypełnienia DropDownList od typów ogłoszeń
            }
        }

        private void InitTypePost()
        {
            KolokwiumApi api = new KolokwiumApi();
            var types = api.GetTypes();
            ddlType.DataSource = types;
            ddlType.DataTextField = "Name";
            ddlType.DataValueField = "Id";
            ddlType.DataBind();
        }

        private void InitPost()
        {
            lblWhenPremium.Visible = false;
        }

        protected void chckPremium_CheckedChanged(object sender, EventArgs e)
        {
            if (chckPremium.Checked)
            {
                lblWhenPremium.Visible = true; // pojawia sie dopiero po kliknieciu przycisku dodaj - do poprawy
            }
            else
            {
                lblWhenPremium.Visible = false;
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            KolokwiumApi api = new KolokwiumApi();
            var post = new Post()
            {
                Description = txtDescription.Text,
                Type = new TypePost { Id = Convert.ToInt32(ddlType.SelectedValue)},
                Date = calDate.SelectedDate,
                Topic = txtTopic.Text,
                isPremium = chckPremium.Checked,
            };

            api.AddPost(post);
        }

        //protected void DataValidator_ServerValidate(object source, ServerValidateEventArgs args)
        //{
            
        //}
    }
}