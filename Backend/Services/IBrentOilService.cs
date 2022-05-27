using Backend.Entities;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Backend.Services
{
    [ServiceContract]
    public interface IBrentOilService
    {
        [OperationContract]
        public List<BrentOil> All();

        [OperationContract]
        public BrentOil? GetById(int id);

        [OperationContract]
        public List<BrentOil> GetDateRange(DateTime startDate, DateTime endDate);
    }
}
