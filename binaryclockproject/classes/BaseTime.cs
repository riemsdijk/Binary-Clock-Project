/*
The MIT License (MIT)

Copyright (c) 2016 Damian Riemsdijk
*/
using System;

namespace binaryclockproject
{
    class BaseTime
    {
        private Number _hour;
        public Number Hour
        {
            get
            {
                return _hour;
            }
        }
        private Number _minute;
        public Number Minute
        {
            get
            {
                return _minute;
            }
        }
        private Number _second;
        public Number Second
        {
            get
            {
                return _second;
            }
        }

        public BaseTime() { }

        public virtual void UpdateTime()
        {
            DateTime timeNow = DateTime.Now;

            _hour.Tens = timeNow.Hour / 10;
            _hour.Ones = timeNow.Hour % 10;

            _minute.Tens = timeNow.Minute / 10;
            _minute.Ones = timeNow.Minute % 10;

            _second.Tens = timeNow.Second / 10;
            _second.Ones = timeNow.Second % 10;
        }
    }
}
