﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamersClub
{
    public class Message
    {
        public string message { get; set; }

        public Message(string message)
        {
            this.message = message;
        }
        public Message() { }
    }
}
