using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploAPI.Models;

namespace ExemploAPI.Models
{
	public class TodoContext: DbContext
	{
		public TodoContext(DbContextOptions<TodoContext> options ): base(options){}


		public DbSet<ExemploAPI.Models.TodoItem> TodoItems { get; set; }
	}
}
