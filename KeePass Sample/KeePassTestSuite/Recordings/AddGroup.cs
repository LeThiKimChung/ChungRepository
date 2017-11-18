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
    ///The AddGroup recording.
    /// </summary>
    [TestModule("ded9e53d-8c7a-4608-8dbe-52e858bbad39", ModuleType.Recording, 1)]
    public partial class AddGroup : ITestModule
    {
        /// <summary>
        /// Holds an instance of the KeePassTestSuite.KeePassTestSuiteRepository repository.
        /// </summary>
        public static KeePassTestSuite.KeePassTestSuiteRepository repo = KeePassTestSuite.KeePassTestSuiteRepository.Instance;

        static AddGroup instance = new AddGroup();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddGroup()
        {
            varGroupName = "Ranorex";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddGroup Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable varGroupName.
        /// </summary>
        [TestVariable("4c3f43ba-f0e0-46f9-9352-67739fe4fa3f")]
        public string varGroupName
        {
            get { return repo.varGroupName; }
            set { repo.varGroupName = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'MainForm.Categories.NewDatabase' at Center.", repo.MainForm.Categories.NewDatabaseInfo, new RecordItemIndex(0));
            repo.MainForm.Categories.NewDatabase.Click(System.Windows.Forms.MouseButtons.Right);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'KeePass.AddGroup' at Center.", repo.KeePass.AddGroupInfo, new RecordItemIndex(1));
            repo.KeePass.AddGroup.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varGroupName'.", new RecordItemIndex(2));
            Keyboard.Press(varGroupName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(3));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
