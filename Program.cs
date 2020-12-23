using CustumerOrderViewer.Models;
using CustumerOrderViewer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CustumerOrderViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CustomerOrderDetailCommand customerOrderDetailCommand = new CustomerOrderDetailCommand(@"Data Source=laptop-u0351eco\karimsql;Initial Catalog=CustumerOrderViewer;Integrated Security=True");

                IList<CustomerOrderDetailModel> customerOrderDetailModels = customerOrderDetailCommand.GetList();

                if (customerOrderDetailModels.Any())
                {
                    foreach (CustomerOrderDetailModel customerOrderDetailModel in customerOrderDetailModels)
                    {
                        Console.WriteLine("{0}: Fullname: {1} {2} (Id: {3}) - purchased {4} for {5} (Id: {6})",
                            customerOrderDetailModel.CustomerOrderId,
                            customerOrderDetailModel.FirstName,
                            customerOrderDetailModel.LastName,
                            customerOrderDetailModel.CustomerId,
                            customerOrderDetailModel.Description,
                            customerOrderDetailModel.Price,
                            customerOrderDetailModel.ItemId
                            );
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong {0}", ex.Message);
            }
        }
    }
}
