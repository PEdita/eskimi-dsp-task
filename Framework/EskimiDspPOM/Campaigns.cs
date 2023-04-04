namespace Framework.EskimiDspPOM
{
    public class Campaigns
    {
        public static void Open()
        {
            LogInClass.Open();
        }

        public static void ClickNewCampaignButton()
        {
            Common.ClickElement("//*[@class='btn btn-primary bg-blue btn-create']");
        }

        public static void ClickCreativeTypeDropdown()
        {
            Common.ClickElement("(//*[@class='select2-selection__arrow'])[1]");
        }

        public static void ClickBannerOption()
        {
            Common.ClickElement("//*[@value='1' and text()='Banner']");
        }

        public static void ClickPopUpBannerCancelButton()
        {
            Common.WaitForElementToBeVisible("//button[text()='Cancel']");
            Common.ClickElement("//button[text()='Cancel']");
        }

        public static void EnterCampaignName(string expectedCampaignName)
        {
            Common.SendKeysToElement("//*[@id='name']", expectedCampaignName);
        }

        public static void ScrollDownToDraftButton()
        {
            Common.ScrollDownToButton("//button[@value='draft']");
        }

        public static void ClickDraftButton()
        {
            Common.ClickElement("//button[@value='draft']");
        }

        public static string GetStatusText()
        {
            return Common.GetElementText("//span[text()='Dra.']");
        }

        public static string GetCampaignText()
        {
            return Common.GetElementText("//*[@class='large-text' and text()='Pasaulis']");
        }
    }
}
