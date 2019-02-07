﻿using Intersect.Client.Framework.Gwen.Control;

namespace Intersect.Client.UI.Menu
{
    public class MenuGuiBase
    {
        private readonly Canvas mMenuCanvas;

        public MainMenu MainMenu;
        private bool mShouldReset;

        public MenuGuiBase(Canvas myCanvas)
        {
            mMenuCanvas = myCanvas;
            InitMenuGui();
        }

        private void InitMenuGui()
        {
            MainMenu = new MainMenu(mMenuCanvas);
        }

        public void Draw()
        {
            if (mShouldReset)
            {
                MainMenu.Reset();
                mShouldReset = false;
            }
            MainMenu.Update();
            mMenuCanvas.RenderCanvas();
        }

        public void Reset()
        {
            mShouldReset = true;
        }

        //Dispose
        public void Dispose()
        {
            if (mMenuCanvas != null) mMenuCanvas.Dispose();
        }
    }
}