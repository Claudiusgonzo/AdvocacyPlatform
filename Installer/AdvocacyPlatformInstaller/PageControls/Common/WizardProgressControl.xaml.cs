﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
namespace AdvocacyPlatformInstaller
{
    using System;
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
    using System.Windows.Navigation;
    using System.Windows.Shapes;

    /// <summary>
    /// User control for showing progress through the wizard.
    /// </summary>
    public partial class WizardProgressControl : UserControl
    {
        /// <summary>
        /// Sets the wizard pages source list.
        /// </summary>
        public static readonly DependencyProperty PagesSourceProperty = DependencyProperty.Register("PagesSource", typeof(WizardProgress), typeof(WizardProgressControl), new PropertyMetadata(new WizardProgress()));

        /// <summary>
        /// Initializes a new instance of the <see cref="WizardProgressControl"/> class.
        /// </summary>
        public WizardProgressControl()
        {
            InitializeComponent();

            DataContext = this;
        }

        /// <summary>
        /// Gets or sets the wizard pages list.
        /// </summary>
        public WizardProgress PagesSource
        {
            get
            {
                return (WizardProgress)GetValue(PagesSourceProperty);
            }

            set
            {
                SetValue(PagesSourceProperty, value);
            }
        }
    }
}
