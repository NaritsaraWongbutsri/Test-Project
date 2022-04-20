using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Project
{
    internal class CurrencyConverter
    {
        private double brunei;
        private double cambodia;
        private double indonesia;
        private double laos;
        private double malaysia;
        private double myanmar;
        private double philippines;
        private double singapore;
        private double vietnam;

        public void addBrunei(double bath)
        {
            this.brunei = bath * 24.2271;
        }

        public double getBrunei()
        {
            return this.brunei;
        }
        public void addCambodia(double bath)
        {
            this.cambodia = bath * 0.8254;
        }

        public double getCombodia()
        {
            return this.cambodia;
        }
        public void addIndonesia(double bath)
        {
            this.indonesia = bath * 2.1769;
        }

        public double getIndonesia()
        {
            return this.indonesia;
        }
        public void addLaos(double bath)
        {
            this.laos = bath * 0.2887;
        }

        public double getLaos()
        {
            return this.laos;
        }
        public void addMalaysia(double bath)
        {
            this.malaysia = bath * 7.8108;
        }

        public double getMalaysia()
        {
            return this.malaysia;
        }
        public void addMyanmar(double bath)
        {
            this.malaysia = bath * 0.0187;
        }

        public double getMyanmar()
        {
            return this.myanmar;
        }
        public void addPhilippines(double bath)
        {
            this.philippines = bath * 0.6228;
        }

        public double getPhilippines()
        {
            return this.philippines;
        }
        public void addSingapore(double bath)
        {
            this.singapore = bath * 24.3376;
        }

        public double getSingapore()
        {
            return this.singapore;
        }
        public void addVietnam(double bath)
        {
            this.vietnam = bath * 0.1458;
        }

        public double getVietnam()
        {
            return this.vietnam;
        }
    }
}
