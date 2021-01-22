using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Command_Pattern
{
    public enum BUTTON_KEY
    {
        BUTTON_X,
        BUTTON_Y,
        BUTTON_A,
        BUTTON_B
    }

    public class InputHandler
    {
        void SwapWeapon()
        {
            Console.WriteLine("무기 변경");
        }

        void SpinMove()
        {
            Console.WriteLine("회전 동작");
        }

        void FireGun()
        {
            Console.WriteLine("무기 발사");
        }

        void Jump()
        {
            Console.WriteLine("점프");
        }

        public void HandleInput(BUTTON_KEY button)
        {
            switch (button)
            {
                case BUTTON_KEY.BUTTON_X:
                    SwapWeapon();
                    break;
                case BUTTON_KEY.BUTTON_Y:
                    SpinMove();
                    break;
                case BUTTON_KEY.BUTTON_A:
                    FireGun();
                    break;
                case BUTTON_KEY.BUTTON_B:
                    Jump();
                    break;
                default:
                    Debug.Assert(false, "Strange Input Value");
                    break;
            }
        }
    }
}
