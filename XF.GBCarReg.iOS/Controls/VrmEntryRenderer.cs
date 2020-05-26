using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XF.GBCarReg.Controls;
using XF.GBCarReg.iOS.CustomRenderers;

[assembly: ExportRenderer(typeof(VrmEntry), typeof(VrmEntryRenderer))]
namespace XF.GBCarReg.iOS.CustomRenderers
{
	public class VrmEntryRenderer : EntryRenderer
	{
		public VrmEntryRenderer()
		{
		}

		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
				Control.BorderStyle = UIKit.UITextBorderStyle.None;
				Control.TextAlignment = UIKit.UITextAlignment.Center;
			}
		}

		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			VrmEntry vrmEntry = (VrmEntry)sender;
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
			base.OnElementPropertyChanged(sender, e);
		}
	}
}
