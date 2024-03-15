using BethanysPieShopHRM.Shared.Domain;
using PieShopHRM.App.Models;

namespace PieShopHRM.App.Pages
{
    public partial class EmployeeOverview
    {
        public List<Employee>? Employees { get; set; } = default;

        protected override void OnInitialized()
        {
            Employees = MockDataService.Employees;


        }

    }
}
