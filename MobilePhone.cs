
using System.Text;

namespace IornSoft_CodeChallange
{
    public static class MobilePhone
    {
        public static List<KeyPadModel> keyPads = new List<KeyPadModel>();

        /// <summary>
        /// Initialize list for Key Number and Letter Array
        /// </summary>
        static MobilePhone()
        {
            keyPads.Add(new KeyPadModel() { KeyNumber = 0, keyLetter = [" "] });
            keyPads.Add(new KeyPadModel() { KeyNumber = 1, keyLetter = ["&", "'", "("] });
            keyPads.Add(new KeyPadModel() { KeyNumber = 2, keyLetter = ["A", "B", "C"] });
            keyPads.Add(new KeyPadModel() { KeyNumber = 3, keyLetter = ["D", "E", "F"] });
            keyPads.Add(new KeyPadModel() { KeyNumber = 4, keyLetter = ["G", "H", "I"] });
            keyPads.Add(new KeyPadModel() { KeyNumber = 5, keyLetter = ["J", "K", "L"] });
            keyPads.Add(new KeyPadModel() { KeyNumber = 6, keyLetter = ["M", "N", "O"] });
            keyPads.Add(new KeyPadModel() { KeyNumber = 7, keyLetter = ["P", "Q", "R", "S"] });
            keyPads.Add(new KeyPadModel() { KeyNumber = 8, keyLetter = ["T", "U", "V"] });
            keyPads.Add(new KeyPadModel() { KeyNumber = 9, keyLetter = ["W", "X", "Y", "Z"] });
        }

        /// <summary>
        /// Get letter based  keynumber and index
        /// </summary>
        /// <param name="keyNumber">This is number for which key pressed</param>
        /// <param name="index">this is index of letter of particular key.</param>
        /// <returns>This will return letter which user try to press in keypad</returns>
        public static string GetLetterByIndex(string keyNumber, int index)
        {
            KeyPadModel? model = keyPads?.Where(x => x.KeyNumber == Convert.ToInt32(keyNumber))?.FirstOrDefault();
            if (model != null)
            {
                return model.keyLetter?[index] ?? "";
            }
            return "";
        }
        /// <summary>
        /// Convert keypad number to letter
        /// </summary>
        /// <param name="input">Input number </param>
        /// <returns>This will return keyword output</returns>
        public static string OldPhonePad(string input)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                char[] Chars = input.ToCharArray();

                int currentIndex = 0;
                string prevNumber = "";
                string res = "";
                foreach (char c in Chars)
                {
                    res = string.Empty;
                    if (c.ToString().Equals("#"))
                    {
                        currentIndex = 0;
                        break;
                    }
                    else if (c.ToString().Equals(" "))
                    {
                        currentIndex = 0;
                    }
                    else if (c.ToString().Equals("*"))
                    {
                        currentIndex = currentIndex - 1;
                        if (sb.Length > 0)
                            sb.Remove(sb.Length - 1, 1);
                    }
                    else
                    {
                        if (prevNumber == c.ToString())
                        {
                            if (sb.Length > 0)
                                sb.Remove(sb.Length - 1, 1);

                            res = GetLetterByIndex(c.ToString(), currentIndex);
                            sb.Append(res);
                            currentIndex = currentIndex + 1;
                        }
                        else
                        {
                            currentIndex = 0;
                            res = GetLetterByIndex(c.ToString(), currentIndex);
                            sb.Append(res);
                            currentIndex = currentIndex + 1;
                        }
                    }
                    prevNumber = c.ToString();
                }
                return sb.ToString();
            }
            catch (Exception)
            {
                return "Input is incorrect. Please try again.";
            }
        }

    }


}