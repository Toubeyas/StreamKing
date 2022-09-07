﻿using StreamKing.Data.Accounts;
using StreamKing.Data.Media;
using System.Collections.Generic;

namespace StreamKing.MainApplication.ViewModels
{
    public class MainWindowViewModel
    {
        public string? ActiveRegionImage { get; set; }

        public MainPage? MainPage { get; set; }

        public List<Media>? MediaList { get; set; }

        public Account? Account { get; set; }

        public MainWindowViewModel()
        {
            MainPage = new LandingPageViewModel();
            MediaList = App._mediaList;
            Account = App._currentUser;
        }
    }

    public class MainPage
    {

    }
}
