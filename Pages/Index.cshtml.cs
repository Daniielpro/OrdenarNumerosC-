using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

public class IndexModel : PageModel
{
    [BindProperty]
    public string Numeros { get; set; }

    public string Ordenados { get; set; }

    public void OnGet()
    {
    }

    public void OnPostOrdenar()
    {
        if (!string.IsNullOrEmpty(Numeros))
        {
            var numerosArray = Numeros.Split(',')
                .Select(n => int.TryParse(n, out int num) ? num : 0)
                .OrderBy(n => n)
                .ToArray();
            Ordenados = string.Join(", ", numerosArray);
        }
    }
}
