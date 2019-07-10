﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core.BaGua
{
    /// <summary>
    /// 坎
    /// </summary>
    public class Kan : DanGua
    {
        public Kan(Point startPoint, int totalWidth, int midWidth, int heigth)
        {
            SanYao = new YinYao(startPoint, totalWidth, midWidth, heigth);
            ErYao = new YangYao(CreateSecondPoint(startPoint, heigth), totalWidth, heigth);
            ChuYao = new YinYao(CreateThirdPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            GuaRectangle = GetGuaRectangle(totalWidth, heigth, midWidth);
            Name = "坎";
            Nature = "水";
            InnateNumber = 6;
            NumbersAcquired = 1;
            InnateOrientation = "正西";
            AcquiredAzimuth = "正北";
        }

        public Kan(Point startPoint) : this(startPoint, GuaConst.TotalWidth, GuaConst.MidWidth, GuaConst.Heigth)
        {

        }

        public Kan():this(new Point() { X=GuaConst.Start_Point_X,Y=GuaConst.Start_Point_Y})
        {

        }
    }
}
