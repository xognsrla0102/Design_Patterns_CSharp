using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern
{
    public static class Utility
    {
        public static void SwapWeapon()
        {
            Console.WriteLine("무기 변경");
        }

        public static void SpinMove()
        {
            Console.WriteLine("회전 동작");
        }

        public static void FireGun()
        {
            Console.WriteLine("무기 발사");
        }

        public static void Jump()
        {
            Console.WriteLine("점프");
        }
    }
}
