using System.Windows.Forms;

namespace LinuxServerManagement
{
    class CheckString
    {
        public static bool CheckStringIsNull(string text, string ItemIdentification)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show($"{ItemIdentification} cannot be null!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true; 
            }else return false;
        }
    }
}
