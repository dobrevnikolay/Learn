namespace WindowBeginningEduGame
{
    public static class ControlManager
    {
        private static MainPageViewModel mMainPage = new MainPageViewModel();

        public static void SwitchControlContext(ControlContext nextControl)
        {
            mMainPage.CurrentControlContext = nextControl;
            mMainPage.OnPropertyChanged(nameof(mMainPage.CurrentControlContext));
        }

    }
}
