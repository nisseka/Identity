using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Models
{
    public class AddPersonInputModel
    {
	[DataType(DataType.Text)]
	[Display(Name="Name:")]
	[Required(ErrorMessage ="A name is required")]
	public string Name { get; set; }

	[DataType(DataType.PhoneNumber)]
	[Display(Name = "Phone Number:")]
	public string PhoneNumber { get; set; }

	[Display(Name = "City:")]
	public int CityId { get; set; }

	[Display(Name = "Languages:")]
	public int[] Languages { get; set; }

	public AddPersonInputModel()
	{
	    Name = string.Empty;
	    PhoneNumber = string.Empty;
	    CityId = 0;
	}
    }
}
