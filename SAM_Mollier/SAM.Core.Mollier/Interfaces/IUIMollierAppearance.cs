﻿using SAM.Core;
using System.Drawing;

namespace SAM.Core.Mollier
{
    public interface IUIMollierAppearance : IJSAMObject
    {
        Color Color { get; set; }

        bool Visible { get; set; }

        int Size { get; set; }

    }
}
