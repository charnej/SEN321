using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLogic
{
    public class Validation
    {
        public static bool ValueNullOrEmpty(string input)
        {
            bool empty = false;       
            if (string.IsNullOrEmpty(input))
            {               
               // MessageBox.Show("Values cannot be empty.","Empty values",MessageBoxButtons.OK,MessageBoxIcon.Error);
                empty = true;
            }
            else
            {
               // MessageBox.Show(input, "Empty values", MessageBoxButtons.OK, MessageBoxIcon.Information);
                empty = true;
            }
            return empty;         
        }

        public static bool LettersOnly(string input)
        {
            bool allLetters = input.All(char.IsLetter);
            bool errors = false;
            if (allLetters == true)
            {
                errors = false;
            }
            else
            {
                errors = true;
            }
            return errors;          
        }

        public static string ValidateInputLetters(string input)
        {
            bool empty = ValueNullOrEmpty(input);
            bool letters = LettersOnly(input);

            if (empty == true)
            {
                MessageBox.Show("Values cannot be empty.","Empty values",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (letters == false)
                {
                    MessageBox.Show("Values can only contain letters.", "Letters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else
                {
                    return input;
                }
            }
            return null;
        }
    }
}
