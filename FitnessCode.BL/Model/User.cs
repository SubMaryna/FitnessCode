using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCode.BL.Model
{
    public class User
    {
        #region Properties

        /// <summary>
        /// NAME
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// GENDER
        /// </summary>
        public Gender Gender { get; }

        /// <summary>
        /// BIRTHDAY
        /// </summary>
        public DateTime BirthDate { get; }

        /// <summary>
        /// WEIGHT
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// HEIGHT
        /// </summary>
        public double Heigt { get; set; }
        #endregion

        /// <summary>
        /// CREATING NEW USER ITEM
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="gender">gender</param>
        /// <param name="birthDate">birthday</param>
        /// <param name="weight">weight</param>
        /// <param name="heigt">height</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public User(string name, 
                    Gender gender, 
                    DateTime birthDate, 
                    double weight, 
                    double heigt)
        {
        
         #region Conditions checking

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Name's field can not be empty or null", nameof(name));
            }

            if(gender == null)
            {
                throw new ArgumentNullException("Gander field can not be empty or null.", nameof(gender));
            }

            if(birthDate < DateTime.Parse("01.01.1900") || birthDate >= DateTime.Now)
            {
                throw new ArgumentException("Birthday does not correct.", nameof(birthDate));
            }

            if(weight <= 0)
            {
                throw new ArgumentException("Weight does not correct.", nameof(weight));
            }
            
            if (heigt <= 0)
            {
                throw new ArgumentException("Height does not correct.", nameof(heigt));
            }
            #endregion


            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Heigt = heigt;

        
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
