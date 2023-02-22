
using ParcelDeliveryBusinessLogic.Services;
using ParcelDeliveryBusinessLogic.Properties;
using ParcelDeliveryBusinessLogic.Processor;
using System.ComponentModel;

namespace ParcelDist.ConsoleApp
{
    class program
    {
        const string XmlFilePath = "Files/Container.xml";
        static void Main(string[] args)
        {
            var parContainer = XMLUtility.LoadXml<ParContainer>(XmlFilePath);
            var defaultOrganization = CreateOrganization();

            Console.WriteLine($"************** {parContainer.Parcels.Count} Parcels is ready to process **************");
            Process(defaultOrganization, parContainer);

            Console.WriteLine();
            Console.WriteLine("*************************     Done!    *************************");


        }

        private static void Process(Organization organization, ParContainer container)
        {
            var service = new ParcelDistributionService();

            foreach (var parcel in container.Parcels)
            {
                service.Send(organization, parcel);

                Thread.Sleep(3000);//Just for simulation
            }
        }
        private static Organization CreateOrganization()
        {
            return new Organization
            {
                Departments = new List<Department>
                {
                    new InsuranceDepartment(),
                    new EmailDepartment(),
                    new RegularDepartment(),
                    new HeavyDepartment(),
                    new AddDepartment()
                }
            };
        }
    }
}

