﻿using System;

namespace ToDoListApp.Model
{
    public class ToDoTask
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public bool IsDone { get; set; }
        public DateTime Deadline { get; set; }
    }
}
