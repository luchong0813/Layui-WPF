﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LayuiTemplate.Dialog.Interface
{
    public interface ILayDialogUserControl
    {
        /// <summary>
        /// 内容
        /// </summary>
        object Content { get; set; }
        /// <summary>
        /// 返回结果
        /// </summary>
        ILayDialogResult Result { get; set; }
        /// <summary>
        /// 初始化
        /// </summary>
        event RoutedEventHandler Loaded;
        /// <summary>
        /// 结束
        /// </summary>
        event RoutedEventHandler Unloaded;
        /// <summary>
        /// 数据上下文
        /// </summary>
        object DataContext { get; set; }
    }
}
