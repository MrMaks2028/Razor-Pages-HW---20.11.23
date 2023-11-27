using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor_Pages_HW___20._11._23.Pages
{
    public class CalculateTriangleSquareModel : PageModel
    {
        public string message = "";
        public void OnGet()
        {
        }
        public void OnPost(int _num1, int _num2)
        {
            message = $"Площадь произвольного треугольника = {_num1 * _num2}";
        }
    }
}
