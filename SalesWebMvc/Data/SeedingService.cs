using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; // DB has been seeded
            }
            else
            {
                Department d1 = new Department(1, "Computers");
                Department d2 = new Department(2, "Electronics");
                Department d3 = new Department(3, "Video Games");
                Department d4 = new Department(4, "Sports & Outdoors");
                Department d5 = new Department(5, "Industrial & Scientific");
                Department d6 = new Department(6, "Software");

                Seller s1 = new Seller(1, "Bob Brown", "b.brown@gmail.com", new DateTime(1988, 4, 21), 1000.0, d4);
                Seller s2 = new Seller(2, "Gary Green", "g.green@gmail.com", new DateTime(1992, 4, 11), 1000.0, d5);
                Seller s3 = new Seller(3, "Alex Grey", "a.grey@gmail.com", new DateTime(1985, 2, 15), 1500.0, d6);
                Seller s4 = new Seller(4, "Donald Furby", "d.furby@gmail.com", new DateTime(1979, 8, 7), 2100.0, d1);
                Seller s5 = new Seller(5, "Kane Jonson", "k.jonson@gmail.com", new DateTime(1993, 11, 9), 1800.0, d2);
                Seller s6 = new Seller(6, "Mathew Dante", "m.dante@gmail.com", new DateTime(1992, 8, 14), 3300.0, d3);

                SalesRecord r1 = new SalesRecord(1, new DateTime(2020, 3, 4), 1200.0, SaleStatus.Billed, s1);
                SalesRecord r2 = new SalesRecord(2, new DateTime(2020, 1, 2), 237.55, SaleStatus.Billed, s2);
                SalesRecord r3 = new SalesRecord(3, new DateTime(2020, 1, 10), 1755.99, SaleStatus.Billed, s3);
                SalesRecord r4 = new SalesRecord(4, new DateTime(2020, 3, 14), 1800.0, SaleStatus.Billed, s4);
                SalesRecord r5 = new SalesRecord(5, new DateTime(2020, 3, 24), 47.55, SaleStatus.Billed, s5);
                SalesRecord r6 = new SalesRecord(6, new DateTime(2020, 2, 15), 469.99, SaleStatus.Billed, s6);
                SalesRecord r7 = new SalesRecord(7, new DateTime(2020, 1, 14), 1489.20, SaleStatus.Billed, s1);
                SalesRecord r8 = new SalesRecord(8, new DateTime(2020, 2, 21), 115.47, SaleStatus.Billed, s2);
                SalesRecord r9 = new SalesRecord(9, new DateTime(2020, 3, 24), 8753.50, SaleStatus.Billed, s3);
                SalesRecord r10 = new SalesRecord(10, new DateTime(2020, 3, 7), 1740.19, SaleStatus.Billed, s4);

                _context.Department.AddRange(d1, d2, d3, d4, d5, d6);

                _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

                _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10);

                _context.SaveChanges();
            }
        }
    }
}
