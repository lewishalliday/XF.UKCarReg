using System.ComponentModel;
using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XF.GBCarReg.Controls;
using XF.GBCarReg.Droid.Controls;

[assembly: ExportRenderer(typeof(VrmEntry), typeof(VrmEntryRenderer))]
namespace XF.GBCarReg.Droid.Controls
{
	public class VrmEntryRenderer : EntryRenderer
	{
		public VrmEntryRenderer(Context context) : base(context)
		{
		}

		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);
			SetBackgroundColor();
			SetTextAttributes();
		}

		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);
			VrmEntry vrmEntry = (VrmEntry)sender;

			if (e.PropertyName == VrmEntry.BackgroundColorProperty.PropertyName)
			{
				SetBackgroundColor();
			}

			if (e.PropertyName == "IsFocused")
			{
				if (vrmEntry.IsFocused)
				{
					vrmEntry.Placeholder = "";
				}
				else
				{
					vrmEntry.Placeholder = "Reg";
				}
			}
		}

		private void SetBackgroundColor()
		{
			if (Control == null)
				return;

			Control.Background = null;
			Control.SetBackgroundColor(Element.BackgroundColor.ToAndroid());
		}

		private void SetTextAttributes()
		{
			if (Control == null)
				return;

			Control.Gravity = Android.Views.GravityFlags.CenterHorizontal | Android.Views.GravityFlags.CenterVertical;
		}
	}
}
