/*
The MIT License (MIT)

Copyright (c) 2016 Damian Riemsdijk
*/
using System;
using System.Windows.Forms;
using System.Drawing;

namespace binaryclockproject
{
    class GraphicalPresentation
    {
        private PictureBox[] _pictureBoxes;
        private Color _colorOfTrue;
        private Color _colorOfFalse;

        public GraphicalPresentation(PictureBox[] PictureBoxes, Color ColorOfTrue, Color ColorOfFalse)
        {
            this._pictureBoxes = PictureBoxes;
            this._colorOfTrue = ColorOfTrue;
            this._colorOfFalse = ColorOfFalse;
        }

        public void SetValue(int value)
        {
            for(int i = 0; i < _pictureBoxes.Length; i++)
            {
                int partOfValue;

                if(i == 0)
                    partOfValue = value % 10;
                else
                    partOfValue = (value / (int)Math.Pow(10, i)) % 10;
                
                if (partOfValue == 1)
                    _pictureBoxes[i].BackColor = _colorOfTrue;
                else
                    _pictureBoxes[i].BackColor = _colorOfFalse;
            }
        }
    }
}
