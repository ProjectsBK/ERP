using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERP.MasterReports_Edit_Delete;
using ERP.Models;
using Microsoft.AspNetCore.Mvc;

namespace ERP.Controllers
{
    [ApiController]
    [Route("Api/[Controller]")]
    public class DataController : Controller
    {
        private readonly IMasterReportsEdit masterReports;
        private readonly MasterReports masterReports1;

        public DataController(IMasterReportsEdit masterReports,MasterReports masterReports1)
        {
            this.masterReports = masterReports;

            this.masterReports1 = masterReports1;
        }

        [HttpDelete]
        [Route("deleteItemMaster_Data")]
        public void deleteItemMaster_Data(string ProductNo) 
        {
            masterReports1.deleteItemMaster_Data(ProductNo);
        }

        [HttpDelete]
        [Route("deleteCustomerMaster_Data")]
        public void deleteCustomerMaster_Data(string CustomerCode) 
        {
            masterReports1.deleteCustomerMaster_Data(CustomerCode);
        }

        [HttpDelete]
        [Route("deleteSupplierMaster_Data")]
        public void deleteSupplierMaster_Data(string supplierCode) 
        {
            masterReports1.deleteSupplierMaster_Data(supplierCode);
        }

        [HttpDelete]
        [Route("deleteMachineMaster_Data")]
        public void deleteMachineMaster_Data(string MachineCode)
        {
            masterReports1.deleteMachineMaster_Data(MachineCode);
        }
        [HttpDelete]
        [Route("deleteGauge_Master")]
        public void deleteGauge_Master(string gaugecode)
        {
            masterReports1.deleteGauge_Master(gaugecode);
        }
        [HttpDelete]
        [Route("deletePrice_Master")]
        public void deletePrice_Master(string PriceMasterCode)
        {
            masterReports1.deletePrice_Master(PriceMasterCode);
        }
        [HttpDelete]
        [Route("deleteGrade_Master")]
        public void deleteGrade_Master(string GradeCode)
        {
            masterReports1.deleteGrade_Master(GradeCode);
        }
        [HttpDelete]
        [Route("deleteWeight_Master")]
        public void deleteWeight_Master(string WeightMasterCode)
        {
            masterReports1.deleteWeight_Master(WeightMasterCode);
        }
        [HttpDelete]
        [Route("deleteProcess_Master")]
        public void deleteProcess_Master(int OperationCode, string ProductNo)
        {
            masterReports1.deleteProcess_Master(OperationCode, ProductNo);
        }

        [HttpPut]
        [Route("EditItemMaster_Data")]
        public void EditItemMaster_Data(ItemMaster itemMaster, string username, string password)
        {
            masterReports.EditItemMaster_Data(itemMaster, username, password);
        }

        [HttpPut]
        [Route("EditCustomerMaster_Data")]
        public void EditCustomerMaster_Data(CustomerMaster customermaster, string username, string password)
        {
            masterReports.EditCustomerMaster_Data(customermaster, username, password);
        }

        [HttpPut]
        [Route("EditSupplierMaster_Data")]
        public void EditSupplierMaster_Data(SupplierMaster suppliermaster, string username, string password)
        {
            masterReports.EditSupplierMaster_Data(suppliermaster, username, password);
        }

        [HttpPut]
        [Route("EditMachineMaster_Data")]
        public void EditMachineMaster_Data(MachineMaster machineMaster, string username, string password)
        {
            masterReports.EditMachineMaster_Data(machineMaster, username, password);
        }

        [HttpPut]
        [Route("EditGauge_Master")]
        public void EditGauge_Master(GaugeMaster gaugeMaster, string username, string password)
        {
            masterReports.EditGauge_Master(gaugeMaster, username, password);
        }

        [HttpPut]
        [Route("EditPrice_Master")]
        public void EditPrice_Master(PriceMaster priceMaster, string username, string password)
        {
            masterReports.EditPrice_Master(priceMaster, username, password);
        }

        [HttpPut]
        [Route("EditGrade_Master")]
        public void EditGrade_Master(GradeMaster gradeMaster, string username, string password)
        {
            masterReports.EditGrade_Master(gradeMaster, username, password);
        }

        [HttpPut]
        [Route("EditWeight_Master")]
        public void EditWeight_Master(WeightMaster weightMaster, string username, string password)
        {
            masterReports.EditWeight_Master(weightMaster, username, password);
        }

        [HttpPut]
        [Route("EditProcess_Master")]
        public void EditProcess_Master(ProcessMaster processmaster, string username, string password)
        {
            masterReports.EditProcess_Master(processmaster, username, password);
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}