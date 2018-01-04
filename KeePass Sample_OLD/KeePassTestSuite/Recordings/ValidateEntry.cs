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
    ///The ValidateEntry recording.
    /// </summary>
    [TestModule("22e7bc49-a08f-4ed4-9426-9dbb96022fbf", ModuleType.Recording, 1)]
    public partial class ValidateEntry : ITestModule
    {
        /// <summary>
        /// Holds an instance of the KeePassTestSuite.KeePassTestSuiteRepository repository.
        /// </summary>
        public static KeePassTestSuite.KeePassTestSuiteRepository repo = KeePassTestSuite.KeePassTestSuiteRepository.Instance;

        static ValidateEntry instance = new ValidateEntry();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateEntry()
        {
            varTitle = "WordPress";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateEntry Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable varTitle.
        /// </summary>
        [TestVariable("353a400f-94b6-4cef-9c83-b7fb02237d16")]
        public string varTitle
        {
            get { return repo.varTitle; }
            set { repo.varTitle = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$varTitle) on item 'MainForm.Entry'.", repo.MainForm.EntryInfo, new RecordItemIndex(0));
            Validate.Attribute(repo.MainForm.EntryInfo, "Text", varTitle);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(1));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
