using System.IO;
using System.Xml.Serialization;

namespace Common
{
    public static class XMLSerializer<T>
    {
        public static void Serialize(T instance, string fileName)
        {
            var formatter = new XmlSerializer(typeof(T));
            using var fs = new FileStream(fileName, FileMode.OpenOrCreate);
            formatter.Serialize(fs, instance);
        }

        public static T Deserialize(string fileName)
        {
            var formatter = new XmlSerializer(typeof(T));
            using var fs = new FileStream(fileName, FileMode.OpenOrCreate);
            return (T)formatter.Deserialize(fs);
        }

    }
}
