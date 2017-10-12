using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Data
{
    public class Datos
    {
        public static List<Imagenes> backimage { get; set; }
        public static List<Imagenes> Datosinit() 
        {
            backimage = new List<Imagenes>();
            backimage.Add(new Imagenes { src = "https://udemy-images.udemy.com/course/750x422/88750_c444_7.jpg", likes = 0, dislikes = 0 });
            backimage.Add(new Imagenes { src = "https://udemy-images.udemy.com/course/750x422/82332_3150_9.jpg", likes = 0, dislikes = 0 });
            backimage.Add(new Imagenes { src = "https://udemy-images.udemy.com/course/240x135/951684_9c1a_2.jpg", likes = 0, dislikes = 0 });
            backimage.Add(new Imagenes { src = "https://www.visualstudio.com/wp-content/uploads/2016/05/xamarin-3-562x309@2xOP.png", likes = 0, dislikes = 0 });
            backimage.Add(new Imagenes { src = "http://www.hexacta.com/wp-content/uploads/2016/03/xamarin.jpg", likes = 0, dislikes = 0 });

            backimage.Add(new Imagenes { src = "test1", likes = 0, dislikes = 0 });
            backimage.Add(new Imagenes { src = "test2", likes = 0, dislikes = 0 });
            backimage.Add(new Imagenes { src = "test3", likes = 0, dislikes = 0 });
            backimage.Add(new Imagenes { src = "test4", likes = 0, dislikes = 0 });
            backimage.Add(new Imagenes { src = "test5", likes = 0, dislikes = 0 });

            return backimage;

        }
    }

    public class Imagenes
    {
      public string src { get; set; }
      public int likes { get; set; }
      public int dislikes { get; set; }


    }
}
