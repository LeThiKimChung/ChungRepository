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

namespace QLTQ
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("ae4475ec-f51a-447b-bed3-0df866c22a9b", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the QLTQRepository repository.
        /// </summary>
        public static QLTQRepository repo = QLTQRepository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
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

            Report.Log(ReportLevel.Info, "Application", "Run application 'C:\\Program Files (x86)\\Microsoft\\Setup\\Quanlytuyenquan.exe' with arguments '' in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication("C:\\Program Files (x86)\\Microsoft\\Setup\\Quanlytuyenquan.exe", "", "C:\\Program Files (x86)\\Microsoft\\Setup", false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'bodoi{Tab}123456'.", new RecordItemIndex(1));
            Keyboard.Press("bodoi{Tab}123456");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmLogin.ĐăngNhập' at 81;11.", repo.FrmLogin.ĐăngNhậpInfo, new RecordItemIndex(2));
            repo.FrmLogin.ĐăngNhập.Click("81;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Frmmain.CậpNhậtDanhMục' at 33;11.", repo.Frmmain.CậpNhậtDanhMụcInfo, new RecordItemIndex(3));
            repo.Frmmain.CậpNhậtDanhMục.Click("33;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Frmmain.XaPhuong' at 52;36.", repo.Frmmain.XaPhuongInfo, new RecordItemIndex(4));
            repo.Frmmain.XaPhuong.Click("52;36");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Frmmain.MaXa' at 7;5.", repo.Frmmain.MaXaInfo, new RecordItemIndex(5));
            repo.Frmmain.MaXa.Click("7;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'QP' with focus on 'Frmmain.MaXa'.", repo.Frmmain.MaXaInfo, new RecordItemIndex(6));
            repo.Frmmain.MaXa.PressKeys("QP");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'QuePhu'.", new RecordItemIndex(7));
            Keyboard.Press("QuePhu");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Frmmain.Them' at 86;8.", repo.Frmmain.ThemInfo, new RecordItemIndex(8));
            repo.Frmmain.Them.Click("86;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Bạn đã thêm thông tin thành công!') on item 'ThongBao.Meg'.", repo.ThongBao.MegInfo, new RecordItemIndex(9));
            Validate.Attribute(repo.ThongBao.MegInfo, "Text", "Bạn đã thêm thông tin thành công!");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ThongBao.ButtonOK' at 57;2.", repo.ThongBao.ButtonOKInfo, new RecordItemIndex(10));
            repo.ThongBao.ButtonOK.Click("57;2");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
