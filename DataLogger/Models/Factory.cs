﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogger.Models
{
  public class Factory
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Created { get; set; }
    public ICollection<Line> line { get; set;}

  }
}
