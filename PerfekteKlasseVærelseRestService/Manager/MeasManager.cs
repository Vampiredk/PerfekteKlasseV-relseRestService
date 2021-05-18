using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PerfekteKlasseVærelseRestService.Models;

namespace PerfekteKlasseVærelseRestService.Manager
{
    public class MeasManager
    {
        private static int _nextId = 1;

        private static List<Measurement> _MeasureList = new List<Measurement>()
        {
            new Measurement(42, 100, _nextId++)
        };


        public List<Measurement> GetAll()
        {
            return _MeasureList;
        }

        public Measurement GetById(int ID)
        {
            return _MeasureList.Find(Meas => Meas.Id == ID);
        }

        public void Delete(int id)
        {
            Measurement Meas = _MeasureList.Find(Meas => Meas.Id == id);
            if (Meas == null) return;
            _MeasureList.Remove(Meas);
        }

        public void Add(Measurement value)
        {
            value.Id = _nextId++;
            _MeasureList.Add(value);
        }

        public Measurement Update(int id, Measurement value)
        {
            Measurement item = _MeasureList.Find(item1 => item1.Id == id);
            if (item == null) return null;
            item.Id = value.Id;
            item.Temp = value.Temp;
            item.Humi = value.Humi;
            return item;
        }
    }
}
