﻿using Android.Graphics.Drawables;
using BuildControlTemplateDemo.Components;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using Microsoft.Maui.Controls.Platform;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;

namespace BuildControlTemplateDemo.Platforms
{
	public static class TextFieldMapper
	{
		public static void Map(IElementHandler handler, IElement view)
		{
			if (view is TextField)
			{
				var casted = (EntryHandler)handler;
				var viewData = (TextField)view;

				var gd = new GradientDrawable();

				gd.SetCornerRadius((int)handler.MauiContext?.Context.ToPixels(viewData.CornerRadius));

				gd.SetStroke((int)handler.MauiContext?.Context.ToPixels(viewData.BorderThickness), viewData.BorderColor.ToAndroid());

				if (viewData.BackgroundColor != null)
				{
					gd.SetColor(viewData.BackgroundColor.ToAndroid());
				}


				casted.PlatformView?.SetBackground(gd);

				int paddingPixel = (int)handler.MauiContext?.Context.ToPixels(10); // Example
				casted.PlatformView?.SetPadding(paddingPixel, paddingPixel, paddingPixel, paddingPixel);
			}
		}
	}
}