﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Vote
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int Value { get; set; }
        public int CommentId { get; set; }
    }
}
