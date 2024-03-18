using BethanysPieShopHRM.Shared.Domain;
using PieShopHRM.App.Models;

namespace PieShopHRM.App.Pages
{
    public partial class EmployeeOverview
    {
        public List<Employee>? Employees { get; set; } = default;
        private Employee? _selectedEmployee;
        private readonly string Title = "Employee Overview";

        protected override void OnInitialized()
        {
            Employees = MockDataService.Employees;


        }
        public void ShowQuickViewPopup(Employee selectedEmployee)
        {
            _selectedEmployee = selectedEmployee;
        }

    }
}
