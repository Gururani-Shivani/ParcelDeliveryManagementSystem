using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ParcelDeliveryBusinessLogic.Properties
{
    [XmlRoot("Container")]
    public class ParContainer
    {
        public int Id { get; set; }
        public DateTime ShippingDate { get; set; }
        [XmlArray("parcels")]
        public List<Parcel> Parcels { get; set; }
    }
}
