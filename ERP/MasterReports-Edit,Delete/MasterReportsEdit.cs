using ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.MasterReports_Edit_Delete
{
    public class MasterReportsEdit : IMasterReportsEdit
    {
        private readonly ERPContext context;

        public MasterReportsEdit(ERPContext context)
        {
            this.context = context;
        }
        public void EditCustomerMaster_Data(CustomerMaster customermaster, string username, string password)
        {
            CustomerMaster cust_Mstr = context.CustomerMaster.FirstOrDefault(a => a.CustomerCode == customermaster.CustomerCode);

            if(cust_Mstr != null)
            {
                cust_Mstr.CustomerName = customermaster.CustomerName;
                cust_Mstr.Location = customermaster.Location;
                cust_Mstr.ModifiedBy = username;
                cust_Mstr.ModifiedDate = DateTime.Now;

                context.SaveChanges();
            }
        }

        public void EditGauge_Master(GaugeMaster gaugeMaster,string username, string password)
        {
            GaugeMaster gauge_Mstr = context.GaugeMaster.FirstOrDefault(a => a.GaugeCode == gaugeMaster.GaugeCode);

            if (gaugeMaster != null)
            {
                gauge_Mstr.Description = gaugeMaster.Description;
                gauge_Mstr.CalibrationDate = gaugeMaster.CalibrationDate;
                gauge_Mstr.ModifiedBy = username;
                gauge_Mstr.ModifiedDate = DateTime.Now;
                gauge_Mstr.Type = gaugeMaster.Type;

                context.SaveChanges();
            }
        }

        public void EditGrade_Master(GradeMaster gradeMaster, string username, string password)
        {
            GradeMaster grde_Mstr = context.GradeMaster.FirstOrDefault(a => a.GradeId == gradeMaster.GradeId);

            grde_Mstr.GradeName = gradeMaster.GradeName;
            grde_Mstr.ModifiedBy = username;
            grde_Mstr.ModifiedDate = DateTime.Now;

            context.SaveChanges();
        }

        public void EditItemMaster_Data(ItemMaster itemMaster, string username, string password)
        {
            ItemMaster item_Mstr = context.ItemMaster.FirstOrDefault(a => a.ProductNo == itemMaster.ProductNo);

            item_Mstr.Description = itemMaster.Description;
            item_Mstr.Condition = itemMaster.Condition;
            item_Mstr.ModelNo = itemMaster.ModelNo;
            item_Mstr.PriceMaster = itemMaster.PriceMaster;
            item_Mstr.ModifiedBy = username;
            item_Mstr.ModifiedDate = DateTime.Now;

            context.SaveChanges();
        }

        public void EditMachineMaster_Data(MachineMaster machineMaster,string username, string password)
        {
            MachineMaster macn_Mstr = context.MachineMaster.FirstOrDefault(a => a.MachineCode == machineMaster.MachineCode);

            macn_Mstr.MachineName = machineMaster.MachineName;
            macn_Mstr.MachineMake = machineMaster.MachineMake;
            macn_Mstr.MachineHourRate = machineMaster.MachineHourRate;
            macn_Mstr.DateOfPurchased = machineMaster.DateOfPurchased;
            macn_Mstr.ModifiedBy = username;
            macn_Mstr.ModifiedDate = DateTime.Now;

            context.SaveChanges();
        }

        public void EditPrice_Master(PriceMaster priceMaster,string username, string password)
        {
            PriceMaster prce_Mstr = context.PriceMaster.FirstOrDefault(a => a.PriceMasterCode == priceMaster.PriceMasterCode);

            prce_Mstr.ConversitionRate = priceMaster.ConversitionRate;
            prce_Mstr.CurrencyType = priceMaster.CurrencyType;
            prce_Mstr.UnitPrice = priceMaster.UnitPrice;
            prce_Mstr.ModifiedBy = username;
            prce_Mstr.ModifiedDate = DateTime.Now;

            context.SaveChanges();
        }

        public void EditProcess_Master(ProcessMaster processmaster,string username, string password)
        {
            ProcessMaster procs_Mstr = context.ProcessMaster.FirstOrDefault(a => a.OperationCode == processmaster.OperationCode && a.ProductNo == processmaster.ProductNo);

            procs_Mstr.OperationName = processmaster.OperationName;
        }

        public void EditSupplierMaster_Data(SupplierMaster suppliermaster, string username, string password)
        {
            SupplierMaster suplir_Mstr = context.SupplierMaster.FirstOrDefault(a => a.SupplierCode == suppliermaster.SupplierCode);

            suplir_Mstr.SupplierName  = suppliermaster.SupplierName;
            suplir_Mstr.Location      = suppliermaster.Location;
            suplir_Mstr.ModifiedBy    = username;
            suplir_Mstr.ModifiedDate  = DateTime.Now;
        }

        public void EditWeight_Master(WeightMaster weightMaster, string username, string password)
        {
            WeightMaster wgt_Mstr = context.WeightMaster.FirstOrDefault(a => a.WeightMasterCode == weightMaster.WeightMasterCode);

            wgt_Mstr.CastingWeight = weightMaster.CastingWeight;
            wgt_Mstr.WeightAfterFullMachining = weightMaster.WeightAfterFullMachining;
        }
    }
}