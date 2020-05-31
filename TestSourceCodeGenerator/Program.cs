using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using AutoNotify;

namespace TestSourceCodeGenerator
{
    public class Program
    {
        public static void Main()
        {
            var model = new ExampleViewModel();

            model.PropertyChanged += (src, args) =>
            {
                Console.WriteLine($"A propriedade {args.PropertyName} foi alterada");
            };

            model.Text = "Felipe";
        }
    }

    // The view model we'd like to augment
    public partial class ExampleViewModel
    {
        [AutoNotify]
        private string _text = "private field text";        

        [AutoNotify(PropertyName = "Count")]
        private int _amount = 5;
    }

}
