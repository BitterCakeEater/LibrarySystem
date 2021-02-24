using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using Library.Classes.Reader_Related;
using Library.Classes.Book_Related;
using System.IO;
using System.Windows.Forms;

namespace Library.Classes
{
    class FileSystem
    {
        public static bool Save_Registration_List(RegistrationList Reg_List)
        {
            BinaryFormatter Bin_F = new BinaryFormatter();

            using (FileStream fstream = new FileStream("RegistrationListData.dat", FileMode.OpenOrCreate))
            {
                try
                {
                    Bin_F.Serialize(fstream, Reg_List);
                    fstream.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(
                    ex.Message,
                    "Увага!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);

                    return false;
                }
            }

            return true;
        }


        public static bool Load_Registration_List(ref RegistrationList Reg_List)
        {
            BinaryFormatter Bin_F = new BinaryFormatter();

            using (FileStream fstream = new FileStream("RegistrationListData.dat", FileMode.OpenOrCreate))
            {
                if (File.Exists("RegistrationListData.dat") && fstream.Length != 0)
                {
                    try
                    {
                        Reg_List = (RegistrationList)Bin_F.Deserialize(fstream);
                        fstream.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(
                        ex.Message,
                        "Увага!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);

                        return false;
                    }

                    return true;
                }

                else
                    return false;
            }
        }


        public static bool Save_Catalog(Catalog Catalog)
        {
            BinaryFormatter Bin_F = new BinaryFormatter();

            using (FileStream fstream = new FileStream("CatalogData.dat", FileMode.OpenOrCreate))
            {
                try
                {
                    Bin_F.Serialize(fstream, Catalog);
                    fstream.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Увага!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);

                    return false;
                }
            }

            return true;
        }


        public static bool Load_Catalog(ref Catalog Catalog)
        {
            BinaryFormatter Bin_F = new BinaryFormatter();

            using (FileStream fstream = new FileStream("CatalogData.dat", FileMode.OpenOrCreate))
            {
                if (File.Exists("CatalogData.dat") && fstream.Length != 0)
                {
                    try
                    {
                        Catalog = (Catalog)Bin_F.Deserialize(fstream);
                        fstream.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(
                        ex.Message,
                        "Увага!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);

                        return false;
                    }

                    return true;
                }

                else
                    return false;
            }
        }
    }
}
