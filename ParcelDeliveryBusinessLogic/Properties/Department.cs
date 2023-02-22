using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelDeliveryBusinessLogic.Properties
{
    public abstract class Department
    {
        public abstract bool Evaluate(Parcel parcel);
        protected void ShowParcelInfo(Parcel parcel)
        {
            Console.WriteLine();
            Console.WriteLine("***********************************************************");
            Console.WriteLine($"From: {parcel.Sender.Name}, To: {parcel.Recipient.Name}");
            Console.WriteLine();
        }
    }

    public class EmailDepartment : Department, IParcelProcess
    {
        public override bool Evaluate(Parcel parcel)
        {
            return parcel.Weight <= 1;
        }

        public void Process(Parcel parcel)
        {
            ShowParcelInfo(parcel);
            Console.WriteLine($"{this.GetType().Name} Processed the parcel.");
        }
    }

    public class RegularDepartment : Department, IParcelProcess
    {
        public override bool Evaluate(Parcel parcel)
        {
            return parcel.Weight > 1 && parcel.Weight <= 10;
        }

        public void Process(Parcel parcel)
        {
            ShowParcelInfo(parcel);
            Console.WriteLine($"{this.GetType().Name} Processed the parcel.");
        }
    }

    public class HeavyDepartment : Department,IParcelProcess
    {
        public override bool Evaluate(Parcel parcel)
        {
            return parcel.Weight > 10;
        }

        public void Process(Parcel parcel)
        {
            ShowParcelInfo(parcel);
            Console.WriteLine($"{this.GetType().Name} Processed the parcel.");
        }
    }

    public class InsuranceDepartment : Department, IParcelSig
    {
        public override bool Evaluate(Parcel parcel)
        {
            return parcel.Value > 1000;
        }

        public void SignOff(Parcel parcel)
        {
            ShowParcelInfo(parcel);
            Console.WriteLine($"{this.GetType().Name} Signed off the parcel.");
        }
    }

    public class AddDepartment : Department, IParcelProcess
    {
        public override bool Evaluate(Parcel parcel)
        {
            return parcel.Weight > 50;
        }

        public void Process(Parcel parcel)
        {
            
        }
    }
}
