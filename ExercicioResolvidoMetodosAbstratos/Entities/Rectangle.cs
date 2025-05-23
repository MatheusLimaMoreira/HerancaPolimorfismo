﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioResolvidoMetodosAbstratos.Entities.Enum;

namespace ExercicioResolvidoMetodosAbstratos.Entities
{
    internal class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double heigth, Color color) : base(color)
        {
            Width = width;
            Height = heigth;
        }
        
        public override double Area()
        {
            return Width * Height;
        }
    }
}
