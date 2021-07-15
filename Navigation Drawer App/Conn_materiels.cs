using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigation_Drawer_App
{
    public class Conn_materiels
    {
        public static ObservableCollection<materiels> materiel { get; set; }
        public static ObservableCollection<sous_categorie> categorie { get; set; }
        public static ObservableCollection<commande> commande { get; set; }

        public static DataClasses1DataContext ds = new DataClasses1DataContext();

        static Conn_materiels()
        {
            materiel = new ObservableCollection<materiels>(ds.materiels.ToList());
            categorie = new ObservableCollection<sous_categorie>(ds.sous_categorie.ToList());
            commande = new ObservableCollection<commande>(ds.commande.ToList());
        }


    }
}
