using System.Runtime.Serialization.Formatters.Binary;
using labofinal;
namespace CLSerializers
{
    public class Serializers
    {
        public static void Serialize(MyData data, String filename)
        {
            System.IO.Stream ms = File.OpenWrite(filename);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(ms, data);
            ms.Flush();
            ms.Close();
            ms.Dispose();
        }

        public static MyData Deserialize(String filename)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = File.Open(filename, FileMode.Open);
            object obj = formatter.Deserialize(fs);
            MyData data = (MyData)obj;
            fs.Flush();
            fs.Close();
            fs.Dispose();

            return data;
        }



    }
}