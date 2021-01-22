using System;

namespace Command_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            InputHandler inputHandler = new InputHandler();

            inputHandler.HandleInput(BUTTON_KEY.BUTTON_A);
            inputHandler.HandleInput(BUTTON_KEY.BUTTON_B);
            inputHandler.HandleInput(BUTTON_KEY.BUTTON_X);
            inputHandler.HandleInput(BUTTON_KEY.BUTTON_Y);
        }
    }
}
