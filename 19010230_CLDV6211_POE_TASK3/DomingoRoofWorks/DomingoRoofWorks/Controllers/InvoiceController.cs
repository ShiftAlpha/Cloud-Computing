using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DomingoRoofWorks;

namespace DomingoRoofWorks.Controllers
{
    public class InvoiceController : Controller
    {
        DomingoRoofWorksEntities db = new DomingoRoofWorksEntities();

        // GET: Invoice
        public ActionResult Index()
        {
            var jOBs = db.JOBs;
            return View(jOBs.ToList());
        }

        // GET: Invoice/InvoiceDetails/5
        public ActionResult InvoiceDetails(int id)
        {
            //var invoice = db.GENERATE_INVOICE(id);
            //ViewBag.Message = invoice;

            string output ="Domingo Roof Works\n\nInvoice\n\n";

            //int jobCardNo = id;
            string jobCardDisplay = $"Job Card Number: {id}";

            JOB jobInvoice = db.JOBs.Where(c => c.JOB_CARD_NO == id).SingleOrDefault();

            string customerDisplay = "Customer Details";
            string custName = $"{jobInvoice.CUSTOMER.CUSTOMER_FISRT_NAME} {jobInvoice.CUSTOMER.CUSTOMER_LAST_NAME}";
            string custEmail = $"{jobInvoice.CUSTOMER.CUSTOMER_EMAIL}";
            string custAddress = $"{jobInvoice.CUSTOMER.CUSTOMER_STREET_ADDRESS}, {jobInvoice.CUSTOMER.CUSTOMER_CITY}, {jobInvoice.CUSTOMER.CUSTOMER_POSTAL_CODE}";


            List<EMPLOYEE_JOB> empJobInvoice = db.EMPLOYEE_JOB.Where(j=> j.JOB_CARD_NO == id).ToList();

            string jobType = jobInvoice.JOB_DETAILS.JOB_TYPE_NAME.ToList().ToString();

            string employeeDisplay = "Employee/Employee(s): || ";
            foreach (EMPLOYEE_JOB emp in empJobInvoice)
            {
                employeeDisplay += $"{emp.EMP_ID}, {emp.EMPLOYEE.EMP_FIRST_NAME}, {emp.EMPLOYEE.EMP_SURNAME} ||";
            }

            List<MATERIALS_JOB> materialJob = db.MATERIALS_JOB.Where(j => j.JOB_CARD_NO == id).ToList();
            string materialsDisplay = "Materials Used: || ";

            foreach (MATERIALS_JOB mj in materialJob)
            {
                materialsDisplay += $"{mj.QUANTITY} X {mj.MATERIAL.MATERIAL_NAME} ||";
            }

            string costs = "Costs:";
            string dailyRate = $"R{jobInvoice.JOB_DETAILS.DAILY_RATE}";
            int numDays = Convert.ToInt32(jobInvoice.NUM_OF_DAYS);
            string subtotal = $"R{Convert.ToInt32(jobInvoice.JOB_DETAILS.DAILY_RATE)*numDays}";
            string vat = $"R{Convert.ToInt32(jobInvoice.JOB_DETAILS.DAILY_RATE) * numDays * 0.15}";
            string total = $"R{(Convert.ToInt32(jobInvoice.JOB_DETAILS.DAILY_RATE) * numDays* 1.15)}";

            //output += $"{jobCardDisplay}\n\n";
            //output += $"{customerDisplay}\n\n";
            //output += $"{custName}\n";
            //output += $"{custEmail}\n";
            //output += $"{custAddress}\n";
            //output += $"{employeeDisplay}\n";
            //output += $"{materialsDisplay}\n";
            //output += $"{costs}\n";
            //output += $"{dailyRate}\n";
            //output += $"{numDays}\n";
            //output += $"{subtotal}\n";
            //output += $"{vat}\n";
            //output += $"{total}\n";

            Session["headings"] = output;
            Session["jobCardDisplay"] = jobCardDisplay;
            Session["customerDisplay"] = customerDisplay;
            Session["custName"] = custName;
            Session["custEmail"] = custEmail;
            Session["custAddress"] = custAddress;
            Session["empDisplay"] = employeeDisplay;
            Session["matDisplay"] = materialsDisplay;
            Session["costs"] = costs;
            Session["dailyRate"] = dailyRate;
            Session["subtotal"] = subtotal;
            Session["vat"] = vat;
            Session["total"] = total;

            //Session["output"] = output;
            //ViewBag.Message = output;
            return View();
        }


    }
}
