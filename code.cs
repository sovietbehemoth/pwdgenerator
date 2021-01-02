using System;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generating password...");
            //generate capital letters
            string[] pwd1 = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            var pwd1cap = pwd1[new Random().Next(0, pwd1.Length)];
            var pwd1cap2 = pwd1[new Random().Next(0, pwd1.Length)];
            var pwd1cap3 = pwd1[new Random().Next(0, pwd1.Length)];

            var bpwd1cap = pwd1[new Random().Next(0, pwd1.Length)];
            var bpwd1cap2 = pwd1[new Random().Next(0, pwd1.Length)];
            var bpwd1cap3 = pwd1[new Random().Next(0, pwd1.Length)];

            var cpwd1cap = pwd1[new Random().Next(0, pwd1.Length)];
            var cpwd1cap2 = pwd1[new Random().Next(0, pwd1.Length)];
            var cpwd1cap3 = pwd1[new Random().Next(0, pwd1.Length)];

            //generate lowercase letters
            var pwd1low = pwd1[new Random().Next(0, pwd1.Length)];
            var pwd1low2 = pwd1[new Random().Next(0, pwd1.Length)];
            var pwd1low3 = pwd1[new Random().Next(0, pwd1.Length)];

            var bpwd1low = pwd1[new Random().Next(0, pwd1.Length)];
            var bpwd1low2 = pwd1[new Random().Next(0, pwd1.Length)];
            var bpwd1low3 = pwd1[new Random().Next(0, pwd1.Length)];

            var cpwd1low = pwd1[new Random().Next(0, pwd1.Length)];
            var cpwd1low2 = pwd1[new Random().Next(0, pwd1.Length)];
            var cpwd1low3 = pwd1[new Random().Next(0, pwd1.Length)];

            //generate numbers
            string[] pwd2 = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            var pwd2int = pwd2[new Random().Next(0, pwd2.Length)];
            var pwd2int2 = pwd2[new Random().Next(0, pwd2.Length)];
            var pwd2int3 = pwd2[new Random().Next(0, pwd2.Length)];

            var bpwd2int = pwd2[new Random().Next(0, pwd2.Length)];
            var bpwd2int2 = pwd2[new Random().Next(0, pwd2.Length)];
            var bpwd2int3 = pwd2[new Random().Next(0, pwd2.Length)];

            var cpwd2int = pwd2[new Random().Next(0, pwd2.Length)];
            var cpwd2int2 = pwd2[new Random().Next(0, pwd2.Length)];
            var cpwd2int3 = pwd2[new Random().Next(0, pwd2.Length)];

            //generate special characters
            string[] pwd3 = { "-", "&", "%", "$" };
            var pwd3sp = pwd3[new Random().Next(0, pwd3.Length)];
            var pwd3sp2 = pwd3[new Random().Next(0, pwd3.Length)];
            var pwd3sp3 = pwd3[new Random().Next(0, pwd3.Length)];

            var bpwd3sp = pwd3[new Random().Next(0, pwd3.Length)];
            var bpwd3sp2 = pwd3[new Random().Next(0, pwd3.Length)];
            var bpwd3sp3 = pwd3[new Random().Next(0, pwd3.Length)];

            var cpwd3sp = pwd3[new Random().Next(0, pwd3.Length)];
            var cpwd3sp2 = pwd3[new Random().Next(0, pwd3.Length)];
            var cpwd3sp3 = pwd3[new Random().Next(0, pwd3.Length)];

            //generate random password
            var pwda = pwd1cap + pwd2int + pwd1low.ToLower() + pwd3sp;
            var pwdb = pwd1low2.ToLower() + pwd3sp2 + pwd1cap2 + pwd2int2;
            var pwdc = pwd2int3 + pwd1cap3 + pwd3sp3 + pwd1low3.ToLower();
            string[] pwdrand = { pwda, pwdb, pwdc };

            var pwdd = bpwd1cap + bpwd2int + bpwd1low.ToLower() + bpwd3sp;
            var pwde = bpwd1low2.ToLower() + bpwd3sp2 + bpwd1cap2 + bpwd2int2;
            var pwdf = bpwd2int3 + bpwd1cap3 + bpwd3sp3 + bpwd1low3.ToLower();
            string[] bpwdrand = { pwdd, pwde, pwdf };

            var pwdg = cpwd1cap + cpwd2int + cpwd1low.ToLower() + cpwd3sp;
            var pwdh = cpwd1low2.ToLower() + cpwd3sp2 + cpwd1cap2 + cpwd2int2;
            var pwdi = cpwd2int3 + cpwd1cap3 + cpwd3sp3 + cpwd1low3.ToLower();
            string[] cpwdrand = { pwdg, pwdh, pwdi };

            var pwdrand1 = pwdrand[new Random().Next(0, pwdrand.Length)];
            var pwdrand2 = bpwdrand[new Random().Next(0, bpwdrand.Length)];
            var pwdrand3 = cpwdrand[new Random().Next(0, cpwdrand.Length)];
            var pwd = pwdrand1 + pwdrand2 + pwdrand3;

            //return password
            Console.WriteLine(pwd);
        }
    }
}
