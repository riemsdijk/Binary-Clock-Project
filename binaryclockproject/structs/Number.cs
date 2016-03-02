namespace binaryclockproject
{
    struct Number
    {
        private int _ones;
        public int Ones
        {
            get
            {
                return _ones;
            }
            set
            {
                _ones = value;
            }
        }

        private int _tens;
        public int Tens
        {
            get
            {
                return _tens;
            }
            set
            {
                _tens = value;
            }
        }
    }
}
