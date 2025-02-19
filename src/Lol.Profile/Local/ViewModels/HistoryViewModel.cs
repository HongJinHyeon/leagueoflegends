﻿using System.Collections.Generic;
using Lol.Database.Controller;
using Lol.Database.Entites.Schema;
using DevNcore.UI.Foundation.Mvvm;

namespace Lol.Profile.Local.ViewModels
{
    public class HistoryViewModel : ObservableObject
    {
        #region Variables

        public List<History> History { get; set; }
        public List<History> PlayChampions { get; set; }
        public List<History> Activities { get; set; }
        #endregion

        #region Constructor

        public HistoryViewModel()
        {
            History = new HistoryApi().GetHistory();
            PlayChampions = new HistoryApi().GetPlayChampions();
            Activities = new HistoryApi().GetActivities();
        }
        #endregion
    }
}
