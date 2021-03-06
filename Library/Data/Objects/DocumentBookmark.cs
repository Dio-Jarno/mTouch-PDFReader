//
// mTouch-PDFReader library
// DocumentBookmark.cs (Document bookmark)
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

namespace mTouchPDFReader.Library.Data.Objects
{
	public class DocumentBookmark
	{
		/// <summary>
		/// Gets the bookmark Id.
		/// </summary>
		public int Id { get; set; }
		
		/// <summary>
		/// Gets the document Id.
		/// </summary>
		public int DocId { get; set; }	
		
		/// <summary>
		/// Gets the bookmark name.
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		/// Gets the bookmark page number.
		/// </summary>
		public int PageNumber { get; set; }
	}
}

