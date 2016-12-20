using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cheeseburger.Domain;
using Cheeseburger.Repository;

namespace Cheeseburger.Service
{
    public class ObjectService
    {

        private CheeseburgerDbContext _context;

        public ObjectService()
        {
            _context = new CheeseburgerDbContext();
        }

        public void AddClass(TargetClass targetClass)
        {
            _context.TargetClasses.Add(targetClass);
            _context.SaveChanges();
        }
    }
}
