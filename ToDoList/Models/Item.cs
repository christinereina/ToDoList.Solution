using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    public int ItemId { get; set; }
    public string Description { get; set; }
  }
}