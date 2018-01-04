﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace KeePassTestSuite.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The EmptyRecycleBin recording.
    /// </summary>
    [TestModule("81c30192-03a8-4968-9c9a-3f62e396872a", ModuleType.Recording, 1)]
    public partial class EmptyRecycleBin : ITestModule
    {
        /// <summary>
        /// Holds an instance of the KeePassTestSuite.KeePassTestSuiteRepository repository.
        /// </summary>
        public static KeePassTestSuite.KeePassTestSuiteRepository repo = KeePassTestSuite.KeePassTestSuiteRepository.Instance;

        static EmptyRecycleBin instance = new EmptyRecycleBin();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EmptyRecycleBin()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EmptyRecycleBin Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'MainForm.Categories.RecycleBin' at Center.", repo.MainForm.Categories.RecycleBinInfo, new RecordItemIndex(0));
            repo.MainForm.Categories.RecycleBin.Click(System.Windows.Forms.MouseButtons.Right);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'KeePass.EmptyRecycleBin' at Center.", repo.KeePass.EmptyRecycleBinInfo, new RecordItemIndex(1));
            repo.KeePass.EmptyRecycleBin.Click();
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'KeePass2.ButtonDelete' at Center.", repo.KeePass2.ButtonDeleteInfo, new RecordItemIndex(2));
                repo.KeePass2.ButtonDelete.Click();
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainForm.Categories.NewDatabase' at Center.", repo.MainForm.Categories.NewDatabaseInfo, new RecordItemIndex(3));
            repo.MainForm.Categories.NewDatabase.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
