﻿using BuildControlTemplateDemo.Components;
using CoreGraphics;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
using UIKit;

namespace BuildControlTemplateDemo.Platforms.MacCatalyst
{
	public static class TextFieldMapper
	{
		public static void Map(IElementHandler handler, IElement view)
		{
			if (view is TextField)
			{
				var casted = (EntryHandler)handler;
				var viewData = (TextField)view;

				UpdateBackground(casted.PlatformView, viewData);

				var paddingViewLeft = new UIView(new CGRect(0, 0, 10, 0)); // Hardcoded for now
				casted.PlatformView.LeftView = paddingViewLeft;
				casted.PlatformView.LeftViewMode = UITextFieldViewMode.Always;

				var paddingViewRight = new UIView(new CGRect(0, 0, 10, 0)); // Hardcoded for now
				casted.PlatformView.RightView = paddingViewRight;
				casted.PlatformView.RightViewMode = UITextFieldViewMode.Always;
			}
		}

		private static void UpdateBackground(UITextField control, TextField entry)
		{
			if (control == null) return;

			control.Layer.CornerRadius = entry.CornerRadius;
			control.Layer.BorderWidth = entry.BorderThickness;
			control.Layer.BorderColor = entry.BorderColor.ToCGColor();
			control.BorderStyle = UITextBorderStyle.Line;
		}
	}
}