﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using EXAM_27._05._21.ViewModels;

namespace EXAM_27._05._21
{
    /// <summary>
    /// Interaction logic for Edition.xaml
    /// </summary>
    public partial class AcademyEdition : Window
    {
        public AcademyEdition()
        {
            InitializeComponent();

            DataContext = new AcademyViewModel();
        }
    }
}
