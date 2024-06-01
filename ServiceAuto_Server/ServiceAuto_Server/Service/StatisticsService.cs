using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceAuto_Server.Domain;
using ServiceAuto_Server.Repository;

namespace ServiceAuto_Server.Service
{
    public class StatisticsService
    {
        private string criterion;
        private List<Car> carList;
        private Dictionary<string, uint> statisticsResult;


        public StatisticsService(string criterion) 
        {
            this.criterion = criterion;
            ICarRepository iCarRepository = new CarRepository();
            this.carList = iCarRepository.CarList();
            this.statisticsResult = new Dictionary<string, uint>();
            if (this.carList != null && this.carList.Count > 0) 
            {
                this.statisticalDetermination();
            }
        }

        public string Criterion 
        {
            get { return this.criterion; }
            set { this.criterion = value; this.statisticalDetermination(); }
        }

        public List<Car> CarList
        {
            get { return this.carList; }
            set { this.carList = value; this.statisticalDetermination(); }
        }

        public Dictionary<string, uint> StatisticsResult
        {
            get { return this.statisticsResult; }
        }

        private void statisticalDetermination() 
        {
            foreach (Car car in this.carList) 
            {
                string key = car.Fuel.ToUpper();
                if(this.criterion.ToUpper() == "BRAND")
                    key = car.Brand.ToUpper();

                if (this.statisticsResult.ContainsKey(key))
                    this.statisticsResult[key]++;
                else this.statisticsResult[key] = 1;
            }
        }
    }
}
