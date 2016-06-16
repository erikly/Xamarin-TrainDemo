using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoApp.Models;

namespace DemoApp
{
    public static class FakeRepo
    {
        public static IEnumerable<Train> Data { get; set; }
        static FakeRepo()
        {
            Data = new List<Train>
            {
                new Train
                {
                    Id=1,
                    Name="Thomas",
                    Description="Stort blått tog",
                    Functions= new List<TrainFunction>
                    {
                        new TrainFunction {Name="Lys", Id=4 },
                        new TrainFunction {Name="Horn", Id=6 }
                    }
                },
                new Train
                {
                    Id=2,
                    Name="Henry",
                    Description="Grinete",
                    Functions=new List<TrainFunction>
                    {
                        new TrainFunction {Name="Kupelys" }
                    }
                }
            };
        }

        public static Train Find(int id)
        {
            return Data.Single(t => t.Id == id);
        }
    }
}
