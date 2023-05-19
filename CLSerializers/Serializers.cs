using labofinal;
using System.Runtime.Serialization.Formatters.Binary;
namespace CLSerializers
{
    public class Serializers
    {
        public static void SerializeBin(MyData data, String filename)
        {
            System.IO.Stream ms = File.OpenWrite(filename);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(ms, data);
            ms.Flush();
            ms.Close();
            ms.Dispose();
        }

        public static MyData DeserializeBin(String filename)
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