using System.IO;
using System.Xml.Serialization;

namespace ParcelDeliveryBusinessLogic.Processor
{
    public class XMLUtility
    {
        public static T LoadXml<T>(string xmlFilePath)
        {
            var serializer = new XmlSerializer(typeof(T));
            var t = default(T);

            using (var streamReader = File.OpenText(xmlFilePath))
            {
                t = (T)serializer.Deserialize(streamReader);
            }

            return t;
        }
    }
}