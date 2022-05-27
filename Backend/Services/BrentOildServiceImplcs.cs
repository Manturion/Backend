using Backend.Entities;
using Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Backend.Services
{
    public class BrentOildServiceImplcs : IBrentOilService
    {
        public List<BrentOil> All()
        {
            using var db = new DatabaseContext();
            return db.BrentOil.ToList();
        }

        public ResourceInfo info()
        {
            using var db = new DatabaseContext();
            var baseQuery = db.BrentOil.Select(entry => entry.Date);
            return new ResourceInfo("BrentOil", baseQuery.Min(), baseQuery.Max());
        }

        public List<BrentOil> GetDateRange(DateTime startDate, DateTime endDate)
        {
            using var db = new DatabaseContext();
            return db.BrentOil.Where(BrentOil => BrentOil.Date >= startDate && BrentOil.Date <= endDate).OrderBy(BrentOil => BrentOil.Date).ToList();
            
        }
    }
}
