using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._5_KETHUA
{
    class Person //Lớp cha
    {
        private string ho;
        private string tendem;
        private string ten;

        public Person()
        {
            
        }

        public Person(string ho, string tendem, string ten)
        {
            this.ho = ho;
            this.tendem = tendem;
            this.ten = ten;
        }

        public string Ho
        {
            get => ho;
            set => ho = value;
        }

        public string Tendem
        {
            get => tendem;
            set => tendem = value;
        }

        public string Ten
        {
            get => ten;
            set => ten = value;
        }

       public void inRaManHinhPerson()
        {

        }
    }
}
