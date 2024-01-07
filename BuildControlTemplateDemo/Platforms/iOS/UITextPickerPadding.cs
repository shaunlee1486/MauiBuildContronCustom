using CoreGraphics;
using Foundation;
using UIKit;

namespace BuildControlTemplateDemo.Platforms
{
	public class UITextPickerPadding : UITextField
	{
		private Thickness _padding = new();

		public Thickness Padding
		{
			get => _padding;
			set
			{
				if (_padding != value)
				{
					_padding = value;
				}
			}
		}

        public UITextPickerPadding()
        {
            
        }

        public UITextPickerPadding(NSCoder coder) : base (coder)
        {
            
        }

        public UITextPickerPadding(CGRect rect) : base (rect)
        {
            
        }

		public override CGRect TextRect(CGRect forBounds)
		{
			var insets = new UIEdgeInsets((float)Padding.Top, (float)Padding.Left, (float)Padding.Bottom, (float)Padding.Right);

			return insets.InsetRect(forBounds);
		}

		public override CGRect PlaceholderRect(CGRect forBounds)
		{
			var insets = new UIEdgeInsets((float)Padding.Top, (float)Padding.Left, (float)Padding.Bottom, (float)Padding.Right);

			return insets.InsetRect(forBounds);
		}

		public override CGRect EditingRect(CGRect forBounds)
		{
			var insets = new UIEdgeInsets((float)Padding.Top, (float)Padding.Left, (float)Padding.Bottom, (float)Padding.Right);

			return insets.InsetRect(forBounds);
		}
	}
}