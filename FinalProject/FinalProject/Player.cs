using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Player
    {
        string email;
        string[] wrongWords;
        int score;

        public Player(string email)
        {
            Email = email;
        }
       
        public string Email
        {
            get => email;
            set
            {
                int count = 0;
                if (value.Contains("@") && !value.Contains(" "))
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (value[i] == '@')
                        {
                            count = i;
                        }
                    }
                    for (int i = count; i < value.Length; i++)
                    {
                        if (value[i] == '.')
                        {
                            email = value;
                        }
                    }
                }
                else
                {
                    throw new ArgumentException("Email is invalid");
                }
            }
        }

       
        public override bool Equals(object obj)
        {
            return ((Player)(obj)).email == email;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
