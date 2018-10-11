using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace library_form
{
    class Storage
    {
        public static string BookFile = "Booker.dat";
        public static string UserFile = "Users.dat";

        public static void Serialize<T>(List<T> objects, string path)
        {
            FileStream fileStream = null;

            try
            {
                fileStream = new FileStream(path, FileMode.OpenOrCreate,
                                               FileAccess.Write, FileShare.None);

                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fileStream, objects);
            }
            catch (IOException ex)
            {

            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }
        }

        public static List<T> Deserialize<T>(string path)
        {
            FileStream fileStream = null;

            try
            {
                fileStream = new FileStream(path, FileMode.Open,
                                               FileAccess.Read, FileShare.Read);

                BinaryFormatter bf = new BinaryFormatter();
                List<T> list = bf.Deserialize(fileStream) as List<T>;

                return list;
            }
            catch (IOException ex)
            {
                return null;
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }
        }

    }
}
