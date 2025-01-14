﻿using Layui.Core.Base;
using Prism.Commands;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace LayuiComponentExample.ViewModels
{
    public class DataGridViewModel : LayuiViewModelBase
    {
        public DataGridViewModel(IContainerExtension container) : base(container)
        {
            LoadedListData();
        }
        private List<object> _ListData;

        public List<object> ListData
        {
            get { return _ListData; }
            set { _ListData = value; }
        }
        private void LoadedListData()
        {
            try
            {
                var random = new Random();
                ListData = new List<object>();
                for (int i = 0; i < 50; i++)
                {
                    int num = random.Next(1, 101);
                    ListData.Add(new { Index = i, Name = "测试" + i, ProgressBarValue = num });
                };
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
