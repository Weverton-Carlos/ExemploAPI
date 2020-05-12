using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploAPI.Models.DTO
{
	public class TodoItemDTO
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public bool IsComplete { get; set; }
	}
}
