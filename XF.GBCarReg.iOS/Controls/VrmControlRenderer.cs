using System;
using System.ComponentModel;
using CoreGraphics;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XF.GBCarReg.Controls;
using XF.GBCarReg.iOS.Controls;

[assembly: ExportRenderer(typeof(VrmControl), typeof(VrmControlRenderer))]

namespace XF.GBCarReg.iOS.Controls
{
    public class VrmControlRenderer : FrameRenderer
    {
        public VrmControlRenderer()
        {
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (e.PropertyName == "X" || e.PropertyName == "Y" || e.PropertyName == "Width" || e.PropertyName == "Height")
            {
                SetFrameShadow();
            }
        }

        public override void Draw(CGRect rect)
        {
            try
            {
                base.Draw(rect);

                SetFrameShadow();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
        }

        private void SetFrameShadow()
        {
            if (Element != null && Element.HasShadow)
            {
                if (Superview != null && Superview.Subviews != null)
                {
                    foreach (var uiView in Superview.Subviews)
                    {
                        var name = uiView.ToString();

                        // Find the Xamarin.Forms ShadowView and customise the look and feel
                        if (uiView != this && uiView.Layer.ShadowRadius > 0 && name.Contains("_ShadowView"))
                        {
                            var shadowRadius = 1.5f;
                            uiView.Layer.ShadowRadius = 12;
                            uiView.Layer.ShadowColor = UIColor.Gray.CGColor;
                            uiView.Layer.ShadowOffset = new CGSize(0,0);
                            uiView.Layer.ShadowOpacity = 0.6f;
                            uiView.Layer.MasksToBounds = false;
                            uiView.Layer.BorderWidth = 1;
                        }
                    }
                }
                Layer.MasksToBounds = true;
                Layer.BorderColor = Element.BorderColor.ToCGColor();
            }
        }
    }
}

