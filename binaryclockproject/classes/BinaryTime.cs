/*
The MIT License (MIT)

Copyright (c) 2016 Damian Riemsdijk
*/
using System;

namespace binaryclockproject
{
    class BinaryTime : BaseTime
    {
        private Number _binaryHour;
        public Number BinaryHour
        {
            get
            {
                return _binaryHour;
            }
        }

        private Number _binaryMinute;
        public Number BinaryMinute
        {
            get
            {
                return _binaryMinute;
            }
        }

        private Number _binarySecond;
        public Number BinarySecond
        {
            get
            {
                return _binarySecond;
            }
        }

        public BinaryTime() : base() {}

        public override void UpdateTime()
        {
            base.UpdateTime();

            ConvertToBinary();
        }

        private void ConvertToBinary()
        {
            _binaryHour.Ones = Int32.Parse(Convert.ToString(Hour.Ones, 2));
            _binaryHour.Tens = Int32.Parse(Convert.ToString(Hour.Tens, 2));

            _binaryMinute.Ones = Int32.Parse(Convert.ToString(Minute.Ones, 2));
            _binaryMinute.Tens = Int32.Parse(Convert.ToString(Minute.Tens, 2));

            _binarySecond.Ones = Int32.Parse(Convert.ToString(Second.Ones, 2));
            _binarySecond.Tens = Int32.Parse(Convert.ToString(Second.Tens, 2));
        }
    }
}
