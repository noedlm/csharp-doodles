using System;
using System.Collections;
using System.Collections.Generic;

namespace testSpace {
	public class Picture : IComparable {
		
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
		});

		listOfPictures.Sort();

		Console.WriteLine(listOfPictures.)

	}
}