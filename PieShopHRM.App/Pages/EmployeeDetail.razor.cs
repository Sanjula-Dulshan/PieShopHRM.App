using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;
using PieShopHRM.App.Models;

namespace PieShopHRM.App.Pages
{
    public partial class EmployeeDetail
    {
        [Parameter]
        public string EmployeeId { get; set; }
        public Employee? Employee { get; set; } = new Employee();
        protected override Task OnInitializedAsync()
        {
            Employee = MockDataService.Employees.FirstOrDefault(e => e.EmployeeId == int.Parse(EmployeeId));
            return base.OnInitializedAsync();
        }
    }
}
