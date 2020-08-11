﻿using EventCore.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventCore.Model;

namespace EventCore.Concrete
{
    public class EventConcrete : IEvent
    {
        private DatabaseContext _context;

        public EventConcrete(DatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<Event> GetAllEvents()
        {
            return _context.Event.ToList();
        }
    }
}
