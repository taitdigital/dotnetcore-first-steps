using System;
using Microsoft.AspNetCore.Components;
using ShopOnline.Models.Dtos;
using ShopOnline.Web.Services.Contracts;

namespace ShopOnline.Web.Pages
{
	public class ProductsBase:ComponentBase
	{
		public ProductsBase()
		{
		}

		[Inject]
		public IProductService productService { get; set; }

		public IEnumerable<ProductDto> Products { get; set; }

        protected override async Task OnInitializedAsync()
        {
			Products = await productService.GetItems();
        }

    }
}

