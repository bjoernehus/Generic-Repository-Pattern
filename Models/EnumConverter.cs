using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace PetShop.Models
{
    public class EnumConverter
    {
        public static string GetStringValue(Enum value)
        {
            string output = null;
            Type type = value.GetType();


            //Look for our 'StringValueAttribute' 
            //in the field's custom attributes
            FieldInfo fi = type.GetField(value.ToString());
            StringValueAttribute[] attrs =
               fi.GetCustomAttributes(typeof(StringValueAttribute),
                                       false) as StringValueAttribute[];

            output = attrs[0].Value;



            return output;
        }

        public class StringValueAttribute : System.Attribute
        {

            private string _value;

            public StringValueAttribute(string value)
            {
                _value = value;
            }

            public string Value
            {
                get { return _value; }
            }

        }
    }

    }
