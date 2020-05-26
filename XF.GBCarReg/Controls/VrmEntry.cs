using Xamarin.Forms;

[assembly: ExportFont("UKNumberPlate.ttf", Alias = "UKNumberPlate")]
namespace XF.GBCarReg.Controls
{
    public class VrmEntry : Entry
    {
        public VrmEntry()
        {
            //FontFamily = Device.RuntimePlatform == Device.iOS
            //    ? "UKNumberPlate"
            //    : "UKNumberPlate.ttf#UKNumberPlate";

            FontFamily = "UKNumberPlate";

            FontSize = 40;
            //BackgroundColor = Color.FromHex("F1DC00");
            Visual = VisualMarker.Default;
            Keyboard = Keyboard.Text;
            Placeholder = "Reg";
            PlaceholderColor = Color.FromHex("6e6e6e");
        }
    }
}