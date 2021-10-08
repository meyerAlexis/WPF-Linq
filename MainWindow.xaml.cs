using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TP_LINQ.Model;

namespace TP_LINQ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private TPDBContext db = new TPDBContext();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ClientAdresse_CLick(object sender, RoutedEventArgs e)
        {

            var liste = db.Adresses
                .Join(db.AssocAdresseClients, a => a.Id, j => j.AdresseId, (a, j) => new { a.AdresseDetail, j.ClientId })
                .Join(db.Clients, j => j.ClientId, c => c.Id, (j, c) => new { adresse = j.AdresseDetail, client = c.Nom });


            var liste2 = db.AssocAdresseClients.Select(x => x);

            var convert = liste2.ToList();
            MessageBox.Show("ok");


            dgData.ItemsSource = liste.ToList();

        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{

        //    for (int i = 1; i < 6; i++)
        //    {
        //        Adresse adresse = new Adresse { AdresseDetail = "Adresse" + i };
        //        db.Adresses.Add(adresse);
        //        db.SaveChanges();

        //        Client client = new Client { Nom = "Client"+i };
        //        db.Clients.Add(client);
        //        db.SaveChanges();
        //        Produit produit = new Produit { Designation = "Produit" + i };
        //        db.Produits.Add(produit);
        //        db.SaveChanges();
        //        Categorie categorie = new Categorie { Nom = "Categorie" + i };
        //        db.Categories.Add(categorie);
        //        db.SaveChanges();
        //    }

        //}


    }
}
