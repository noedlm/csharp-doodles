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
			return name = order + ":: (" + width + "x" + height + ") - " + photographer;
		}

	}

	public class PictureHandler {
        static void Main() {
            Picture foto = new Picture(64, 64, 15, "first Picture!", "Noe");

            List<Picture> listOfPictures = new List<Picture>();
            listOfPictures.Add(foto);
            listOfPictures.Add(new Picture
            {
                width = 80,
                height = 80,
                order = 10,
                name = "awesome picture"
            });

            Console.WriteLine("before order:");
            foreach (Picture p in listOfPictures) {
                Console.WriteLine(p.ToString());
            }

            listOfPictures.Sort();

            Console.WriteLine("after order:");
            foreach (Picture p in listOfPictures) {
                Console.WriteLine(p.ToString());
            }
        }
	}
}