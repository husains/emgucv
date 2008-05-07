using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Emgu.CV
{
    public interface IImage
    {
        [ExposableMethod(Exposable=false)]
        Bitmap AsBitmap();

        int Width 
        {
            [ExposableMethod(Exposable = false)]
            get;
        }

        int Height 
        {
            [ExposableMethod(Exposable = false)]
            get;
        }

        IImage Not();

        [ExposableMethod(Exposable = false)]
        void Save(String fileName);
    }
}
