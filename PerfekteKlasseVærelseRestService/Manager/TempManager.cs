using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PerfekteKlasseVærelseRestService.Models;

namespace PerfekteKlasseVærelseRestService.Manager
{
    public class TempManager
    {
        private static int _nextId = 1;

        private static List<Temp> _TempList = new List<Temp>()
        {
            new Temp(42,_nextId++)
        };


        public List<Temp> GetAll()
        {
            return _TempList;
        } 

        public Temp GetById(int ID)
        {
            return _TempList.Find(Temps => Temps.id == ID);
        }

        public void Delete(int id)
        {
            Temp Temp = _TempList.Find(Temp => Temp.id == id);
            if (Temp == null) return;
            _TempList.Remove(Temp);
        }

        public void Add(Temp value)
        {
            value.id = _nextId++;
            _TempList.Add(value);
        }

        public Temp Update(int id, Temp value)
        {
            Temp item = _TempList.Find(item1 => item1.id == id);
            if (item == null) return null;
            item.id = value.id;
            item.temperatur = value.temperatur;
            return item;
        }
    }
}
