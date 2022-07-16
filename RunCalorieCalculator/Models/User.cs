using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunCalorieCalculator.Models
{
    [AddINotifyPropertyChangedInterface]
    public class User
    {
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public int Duration { get; set; }

        public int RunSpeed { get; set; }

    }
}
