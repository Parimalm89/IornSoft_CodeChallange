
using IornSoft_CodeChallange;


string result1 = MobilePhone.OldPhonePad("222 2 22#");// O/P = CAB
Console.WriteLine("222 2 22# => " + result1);

string result2 = MobilePhone.OldPhonePad("33#");// O/P = E
Console.WriteLine("33# => " + result2);

string result3 = MobilePhone.OldPhonePad("227*#");// O/P = B
Console.WriteLine("227*# => " + result3);

string result4 = MobilePhone.OldPhonePad("4433555 555666#");// O/P = HELLO
Console.WriteLine("4433555 555666# => " + result4);

string result5 = MobilePhone.OldPhonePad("8 88777444666*664#");// O/P = TURING
Console.WriteLine("8 88777444666*664# => " + result5);

string result6 = MobilePhone.OldPhonePad("8 88irjdfnvj3489p5777444666 * 664#");// invalid iput
Console.WriteLine("8 88irjdfnvj3489p5777444666 * 664# => " + result6);