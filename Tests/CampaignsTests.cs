using Framework.EskimiDspPOM;
using Framework;
using NUnit.Framework;

namespace Tests
{
    public class CampaignsTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Initialize();
            Campaigns.Open();
        }

        [Test] 
        public void CreateNewCampaign()
        {
            string expectedCampaignName = "Pasaulis";
            string expectedStatus = "Dra.";

            Campaigns.ClickNewCampaignButton();
            Campaigns.ClickCreativeTypeDropdown();
            Campaigns.ClickBannerOption();
            Campaigns.ClickPopUpBannerCancelButton();
            Campaigns.EnterCampaignName(expectedCampaignName);
            Campaigns.ScrollDownToDraftButton();
            Campaigns.ClickDraftButton();
            string actualStatus = Campaigns.GetStatusText();
            string actualCampaignName = Campaigns.GetCampaignText();

            Assert.AreEqual(expectedCampaignName, actualCampaignName);
            Assert.AreEqual(expectedStatus, actualStatus);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
