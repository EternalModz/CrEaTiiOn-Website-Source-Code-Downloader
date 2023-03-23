﻿using System.ComponentModel;
using System.Windows.Forms;
using Dark.Net;

namespace CBH_WebDLTool
{
    public partial class ThemeForm : Form
    {
        public ThemeForm(Theme theme)
            : base()
        {
            DarkNet.Instance.SetWindowThemeForms(this, theme);
            Invalidate();
        }

        public ThemeForm()
            : this(Theme.Auto)
        {
        }

        public ThemeForm(IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
}
