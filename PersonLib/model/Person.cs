using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLib.model
{
    public class Person
    {
		// instans felter
		private int _id;
		private string _name;
		private string _phone;


		// Properties
		public string Phone
		{
			get { return _phone; }
			set 
			{ 
				if (value.Length != 8)
				{
					throw new ArgumentException($"Tlf skal være 8 tegn");
				}
				try
				{
					int p = int.Parse(value);
				} catch (FormatException fe) 
				{
					throw new ArgumentException("tlf nummer er kun cifre");
				}
				_phone = value; 
			}
		}


		public string Name
		{
			get { return _name; }
			set 
			{ 
				//if (string.IsNullOrEmpty(value))
				//{
				//	throw new ArgumentNullException("navn skal have en værdi");
				//}
				if (string.IsNullOrEmpty(value) || value.Length < 4)
				{
					throw new ArgumentException("Navn skal være mindst 4 tegn langt ");
				}
				_name = value; 
			}
		}


		public int Id
		{
			get { return _id; }
			set 
			{ 
				if (value < 1000 || 99999 < value)
				{
					throw new ArgumentOutOfRangeException($"id  skal være mellem 1000 og 99999 men var {value}");
				}
				_id = value; 


				/* mac */
				if (1000 <= value && value <= 99999)
				{
					_id = value;
				}
				else
				{
					throw new ArgumentOutOfRangeException($"id  skal være mellem 1000 og 99999 men var {value}");
				}
			}
		}

        public Person():this(1000, "00000000", "dummy")
        {
        }

        public Person(int id, string phone, string name)
        {
            Phone = phone;
            Name = name;
            Id = id;
        }

        public override string ToString()
        {
            return $"{{{nameof(Phone)}={Phone}, {nameof(Name)}={Name}, {nameof(Id)}={Id.ToString()}}}";
        }
    }
}
