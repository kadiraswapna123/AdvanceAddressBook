using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAddressBookSystem
{
    internal class OpenCloseDatabase
    {
        public ActionResult Index(HttpPostedFileBase file)
        {
            // Verify that the user selected a file
            if (file != null && file.ContentLength > 0)
            {
                var path = FileHelper.GetFilePath(file);
                string filePath = path.Item1;

                if (!string.IsNullOrEmpty(filePath))
                {
                    if (path.Item2 == "." + Enums.FileType.csv.ToString())
                    {
                        List<Company> companiesList = Convertor.ConvertCsvToCompanyModel(filePath);

                        if (companiesList != null && companiesList.Count() > 0)
                        {
                            try
                            {
                                foreach (var company in companiesList)
                                {
                                    companyRepository.SaveCompanyItem(company);
                                }
                            }
                            catch (Exception ex)
                            {
                                obj.Handle("Something went wrong at save" + ex.Message);
                            }
                        }

                        TempData["Message"] = "The file import was sucessfull!";
                    }
                }
            }

            TempData["ErrorMessage"] = "Please select file";

            // redirect back to the index action to show the form once again           
            return RedirectToAction("Index");
        }
    }
}
