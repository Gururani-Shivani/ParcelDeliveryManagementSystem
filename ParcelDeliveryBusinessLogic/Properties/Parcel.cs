using System.Xml.Serialization;

namespace ParcelDeliveryBusinessLogic.Properties
{

    public class Parcel
    {
        public Parcel()
        {

        }

        public Parcel(double weight, double value)
        {
            Weight = weight;
            Value = value;
        }
        public Company Sender { get; set; }
        [XmlElement("Receipient")]
        public Person Recipient { get; set; }
        public double Weight { get; set; }
        public double Value { get; set; }
    }
}
