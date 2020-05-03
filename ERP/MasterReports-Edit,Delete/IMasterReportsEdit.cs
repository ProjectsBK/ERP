using ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.MasterReports_Edit_Delete
{
    public interface IMasterReportsEdit
    {
        public void EditItemMaster_Data(ItemMaster itemMaster, string username, string password);
        public void EditCustomerMaster_Data(CustomerMaster customermaster, string username, string password);
        public void EditSupplierMaster_Data(SupplierMaster suppliermaster, string username, string password);
        public void EditMachineMaster_Data(MachineMaster machineMaster, string username, string password);
        public void EditGauge_Master(GaugeMaster gaugeMaster, string username, string password);
        public void EditPrice_Master(PriceMaster priceMaster, string username, string password);
        public void EditGrade_Master(GradeMaster gradeMaster, string username, string password);
        public void EditWeight_Master(WeightMaster weightMaster, string username, string password);
        public void EditProcess_Master(ProcessMaster processmaster, string username, string password);
    }
}