using ERP.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.MasterReports_Edit_Delete
{
    public class MasterReports : IMasterReports
    {
        private readonly ERPContext context;

        public MasterReports(ERPContext context)
        {
            this.context = context;
        }
        public void deleteCustomerMaster_Data(string CustomerCode)
        {
            context.Remove(context.CustomerMaster.FirstOrDefault(a => a.CustomerCode == CustomerCode));
            context.SaveChanges();
        }

        public void deleteGauge_Master(string gaugecode)
        {
            context.Remove(context.GaugeMaster.FirstOrDefault(a => a.GaugeCode == gaugecode));
            context.SaveChanges();
        }

        public void deleteGrade_Master(string GradeCode)
        {
            context.Remove(context.GradeMaster.FirstOrDefault(a => a.GradeId == GradeCode));
            context.SaveChanges();
        }

        public void deleteItemMaster_Data(string ProductNo)
        {
            context.Remove(context.ItemMaster.FirstOrDefault(a => a.ProductNo == ProductNo));
            context.SaveChanges();
        }

        public void deleteMachineMaster_Data(string MachineCode)
        {
            context.Remove(context.MachineMaster.FirstOrDefault(a => a.MachineCode == MachineCode));
            context.SaveChanges();
        }

        public void deletePrice_Master(string PriceMasterCode)
        {
            context.Remove(context.PriceMaster.FirstOrDefault(a => a.PriceMasterCode == PriceMasterCode));
            context.SaveChanges();
        }

        public void deleteProcess_Master(int OperationCode, string ProductNo)
        {
            context.Remove(context.ProcessMaster.FirstOrDefault(a => a.ProductNo == ProductNo && a.OperationCode == OperationCode));
            context.SaveChanges();
        }

        public void deleteSupplierMaster_Data(string supplierCode)
        {
            context.Remove(context.SupplierMaster.FirstOrDefault(a => a.SupplierCode == supplierCode));
            context.SaveChanges();        
        }

        public void deleteWeight_Master(string WeightMasterCode)
        {
            context.Remove(context.WeightMaster.FirstOrDefault(a => a.WeightMasterCode == WeightMasterCode));
            context.SaveChanges();
        }
    }
}
