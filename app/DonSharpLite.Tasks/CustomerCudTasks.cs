using System;
using DonSharpLite.Domain;
using DonSharpLite.Tasks.ViewModels;
using SharpLite.Domain.DataInterfaces;

namespace DonSharpLite.Tasks
{
    public class CustomerCudTasks : BaseEntityCudTasks<Customer, EditCustomerViewModel>
    {
        public CustomerCudTasks(IRepository<Customer> entityRepository) : base(entityRepository)
        {
        }

        protected override void TransferFormValuesTo(Customer toUpdate, Customer fromForm)
        {
            toUpdate.AccountNumber = (fromForm.AccountNumber ?? "").Trim();
            toUpdate.EmailAddress = (fromForm.EmailAddress ?? "").Trim();
            toUpdate.AccountNumber = (fromForm.AccountNumber ?? "").Trim();
            toUpdate.AccountNumber = (fromForm.AccountNumber ?? "").Trim();
        }
    }
}