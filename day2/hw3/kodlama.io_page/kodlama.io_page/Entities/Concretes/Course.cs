﻿using kodlama.io_page.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama.io_page.Entities.Concretes;

public class Course:IEntity
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int CategoryId { get; set; }
    public int InstructorId { get; set; }
}
