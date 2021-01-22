using System
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
        public void HandleInput(BUTTON_KEY button)
        {
            switch (button)
            {
                case BUTTON_KEY.BUTTON_X:
                    Utility.SwapWeapon();
                    break;
                case BUTTON_KEY.BUTTON_Y:
                    Utility.SpinMove();
                    break;
                case BUTTON_KEY.BUTTON_A:
                    Utility.FireGun();
                    break;
                case BUTTON_KEY.BUTTON_B:
                    Utility.Jump();
                    break;
                default:
                    Debug.Assert(false, "Strange Input Value");
                    break;
            }
        }
    }
}
