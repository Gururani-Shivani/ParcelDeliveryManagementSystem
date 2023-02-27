using Xunit;
using ParcelDeliveryBusinessLogic.Properties;
using ParcelDeliveryBusinessLogic.Processor;

namespace FM.ParcelDist.UnitTests
{
    public class XMLUtilityTest
    {
        [Theory]
        [InlineData("Files/Container.xml")]
        public void LoadXml_To_ParcelContainer(string xmlFilePath)
        {
            #region Prepare

            #endregion

            #region Act

            var container = XMLUtility.LoadXml<ParContainer>(xmlFilePath);

            #endregion

            #region Check

            Assert.NotNull(container);
            Assert.Equal(4, container.Parcels.Count);
            Assert.Equal(68465468, container.Id);

            #endregion
        }

        private static object LoadXml<T>(string xmlFilePath)
        {
            throw new NotImplementedException();
        }
    }
}
