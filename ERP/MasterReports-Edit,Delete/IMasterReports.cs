using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.MasterReports_Edit_Delete
{
    public interface IMasterReports
    {
        public void deleteItemMaster_Data(string ProductNo);
        public void deleteCustomerMaster_Data(string CustomerCode);
        public void deleteSupplierMaster_Data(string supplierCode);
        public void deleteMachineMaster_Data(string MachineCode);
        public void deleteGauge_Master(string gaugecode);
        public void deletePrice_Master(string PriceMasterCode);
        public void deleteGrade_Master(string GradeCode);
        public void deleteWeight_Master(string WeightMasterCode);
        public void deleteProcess_Master(int OperationCode, string ProductNo);
    }
}
