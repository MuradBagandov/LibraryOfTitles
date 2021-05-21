﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOfTitles.ViewModels
{
    internal class MainWindowViewModel: Base.ViewModel
    {
        #region Properties

        private string _title = "LibraryOfTitle";
        public string Title
        {
            get => _title;
            set => Set(ref _title, value);
        } 

        #endregion
    }
}
