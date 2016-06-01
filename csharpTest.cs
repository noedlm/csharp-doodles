using System;
using System.Collections;
using System.Collections.Generic;

namespace testSpace {
	public class Picture : IComparable<Picture> {
		
		public int width {get; set;}
		public int height {get; set;}
		public int order {get; set;}
		public string name {get; set;}
		public string photographer {get; set;}

		public Picture() {}

		public Picture(int w, int h, int o, string n, string p) {
			width = w;
			height = height;
			order = o;
			name = n;
			photographer = p;
		} 

		public int CompareTo(Picture pic) {
			if (pic == null)
				return 1;
			else if (this.order == pic.order)
				return this.name.CompareTo(pic.name);
			else
				return this.order.CompareTo(pic.order);
		}

		public override string ToString() {
			return name = " (" + width + "x" + height + " - " + photographer;
		}

	}

	public class PictureHandler {
		List<Picture> listOfPictures = new List<Picture>()
		listOfPictures.Add(new Picture() {
			width = 64;
			height = 64;
			order = 0;
			name = "first picture!";
			photographer = "Noe";
		});
		listOfPictures.Add(new Picture() {
			width = 128; 
			height =  128;
			order = 1; 
			name = "Awesome Picture!";
		});
		listOfPictures.Add(new Picture() {
			width = 38;
			height = 56;
			order = 2;
			name = "breakfast";
			photographer = "Noe";
		});

		listOfPictures.Sort();

		foreach (Picture pic in listOfPictures) {
			Console.WriteLine(pic.ToString());
		}

	}
}