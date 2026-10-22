using System;

namespace project
{

    struct CarSpec
    {

        private string model;
        private int caiPutere;


        public void SetValues(string modelMasina, int cai)
        {
            this.model = modelMasina;
            this.caiPutere = cai;
        }


        public void PrintValues()
        {
            Console.WriteLine("Masina: " + model + " are " + caiPutere + " cai putere.");
        }
    }
}