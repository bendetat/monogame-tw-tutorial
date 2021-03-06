﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;

namespace ShooterGame.Windows.Core
{
    public class ShooterGameInputState
    {
        public ShooterGameInputState(GamePadState currentGamePadState, GamePadState previousGamePadState,
            KeyboardState currentKeyboardState, KeyboardState previousKeyboardState, MouseState currentMouseState,
            MouseState previousMouseState,
            TouchPanelState currentTouchPanelState,
            TouchPanelState previousTouchPanelState,
            GameTime gameTime)
        {
            GameTime = gameTime;
            PreviousMouseState = previousMouseState;
            CurrentTouchPanelState = currentTouchPanelState;
            PreviousTouchPanelState = previousTouchPanelState;
            CurrentMouseState = currentMouseState;
            PreviousKeyboardState = previousKeyboardState;
            CurrentKeyboardState = currentKeyboardState;
            PreviousGamePadState = previousGamePadState;
            CurrentGamePadState = currentGamePadState;
        }

        public GamePadState CurrentGamePadState { get; private set; }
        public GamePadState PreviousGamePadState { get; private set; }
        public KeyboardState CurrentKeyboardState { get; private set; }
        public KeyboardState PreviousKeyboardState { get; private set; }
        public MouseState CurrentMouseState { get; private set; }
        public MouseState PreviousMouseState { get; private set; }
        public TouchPanelState CurrentTouchPanelState { get; private set; }
        public TouchPanelState PreviousTouchPanelState { get; private set; }
        public GameTime GameTime { get; private set; }
    }
}