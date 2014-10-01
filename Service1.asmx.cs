using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceMetroClient
{
    /// <summary>
    /// Zusammenfassungsbeschreibung für "Service1"
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Wenn der Aufruf dieses Webdiensts aus einem Skript mithilfe von ASP.NET AJAX zulässig sein soll, heben Sie die Kommentarmarkierung für die folgende Zeile auf. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {

        //Parametererklärung:
        //  ID          = Charakter/Benutzer-ID
        //  count       = Anzahl
        //  isVerified  = ob der Nutzer Daten zu seinem eigenem Char abruft oder einem fremden
        //  item        = Itemname
        //  ph          = physischer Schaden
        //  st          = geistiger Schaden


        [WebMethod]
        //checkt ob der User vorhanden ist
        public string verifyUser(int ID)
        {
            return "";
        }

        [WebMethod]
        //ruft die letzte Änderung ab
        public string getLastChange()
        {
            return "";
        }

        [WebMethod]
        //ruft den Charakter ab
        public string getCharacter(int ID)
        {
            return "";
        }

        [WebMethod]
        //ruft das Inventar des Charakters ab
        public string getInventory(int ID, bool isVerified)
        {
            return "";
        }

        [WebMethod]
        //setzt den Schadensmonitor des Charakters
        public bool setDamage(int ID, int ph, int st)
        {
            return true;
        }

        [WebMethod]
        //ändert Anzahl der Items
        public bool alterItemAmount(int ID, string Item, int count)
        {
            if (count == 0)
            {
                //entferne Eintrag
            }
            else
            {
                //ändere Anzahl
            }
            return true;
        }

        [WebMethod]
        //fügt ein NEUES Item in bestimmer Anzahl hinzu
        public bool addItemAmount(int ID, string Item, int count)
        {
            return true;
        }

        [WebMethod]
        //ändert die Munitionszahl, alle Typen sollen im schon in der Datenbank vorhanden sein und auf 0 gesetzt sein
        public bool setAmmoAmount(int ID, string Item, int count)
        {
            return true;
        }
    }
}