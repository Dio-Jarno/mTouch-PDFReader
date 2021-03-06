//
// mTouch-PDFReader library
//   PageViewController.cs
//
//  Author:
//       Alexander Matsibarov (macasun) <amatsibarov@gmail.com>
//
//  Copyright (c) 2012 Alexander Matsibarov
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using mTouchPDFReader.Library.Data.Enums;

namespace mTouchPDFReader.Library.Views.Core
{
	public class PageViewController : UIViewController
	{
		#region Fields
		/// <summary>
		/// The PageView frame.
		/// </summary>
		private RectangleF _ViewFrame;

		/// <summary>
		/// The auto scale modes.
		/// </summary>
		private AutoScaleModes _AutoScaleMode;

		/// <summary>
		/// Gets the page number.
		/// </summary>
		public int PageNumber { get; private set; }

		/// <summary>
		/// Gets the PageView.
		/// </summary>
		public PageView PageView {
			get {
				return View as PageView;
			}
		}

		/// <summary>
		/// Gets the value indicaties whether the page is not Empty page.
		/// </summary>
		public bool IsNotEmptyPage {
			get {
				return PageView != null;
			}
		}
		#endregion

		#region Constructors
		public PageViewController(IntPtr handle) : base(handle)
		{
		}
		
		[Export("initWithCoder:")]
		public PageViewController(NSCoder coder) : base(coder)
		{
		}
		
		public PageViewController(RectangleF viewFrame, AutoScaleModes autoScaleMode, int pageNumber) : base(null, null)
		{
			_ViewFrame = viewFrame;
			_AutoScaleMode = autoScaleMode;
			PageNumber = pageNumber;
		}	
		#endregion

		#region UIViewController
		/// <summary>
		/// Called after the controller’s view is loaded into memory.
		/// </summary>
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			if (PageNumber == -1) {
				View.BackgroundColor = UIColor.Clear;
			} else {
				View = new PageView(_ViewFrame, _AutoScaleMode, PageNumber);
			}
		}

		/// <summary>
		/// Called when permission is shought to rotate
		/// </summary>
		public override bool ShouldAutorotateToInterfaceOrientation(UIInterfaceOrientation toInterfaceOrientation)
		{
			return true;
		}
		#endregion
	}
}

