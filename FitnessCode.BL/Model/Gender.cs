using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCode.BL.Model
{
    /// <summary>
    /// GENDER
    /// </summary>
    public class Gender
    {
        /// <summary>
        /// NAME OF GENDER
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// CREATING NEW GENDER
        /// </summary>
        /// <param name="name">NAME OF GENDER</param>
        /// <exception cref="ArgumentNullException"></exception>
        public Gender(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Gander field can not be empty or null", nameof(name));
            }
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
