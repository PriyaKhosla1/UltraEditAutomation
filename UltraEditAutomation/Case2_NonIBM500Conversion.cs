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

namespace UltraEditAutomation
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Case2_NonIBM500Conversion recording.
    /// </summary>
    [TestModule("b596690a-84cb-4914-80f2-48ed9792ec5a", ModuleType.Recording, 1)]
    public partial class Case2_NonIBM500Conversion : ITestModule
    {
        /// <summary>
        /// Holds an instance of the UltraEditAutomationRepository repository.
        /// </summary>
        public static UltraEditAutomationRepository repo = UltraEditAutomationRepository.Instance;

        static Case2_NonIBM500Conversion instance = new Case2_NonIBM500Conversion();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Case2_NonIBM500Conversion()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Case2_NonIBM500Conversion Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'UltraEdit64Bit.ApplicationMenu' at 18;14.", repo.UltraEdit64Bit.ApplicationMenuInfo, new RecordItemIndex(0));
            //repo.UltraEdit64Bit.ApplicationMenu.Click("18;14");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Uedit64.Open' at 55;28.", repo.Uedit64.OpenInfo, new RecordItemIndex(1));
            //repo.Uedit64.Open.Click("55;28");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'C:\\UltraEditFiles\\ue-20241025T061201Z-006\\ue\\encodingTestsBOM\\langFile_ASCII_UNIX.txt' with focus on 'Open.Text1148'.", repo.Open.Text1148Info, new RecordItemIndex(2));
            //repo.Open.Text1148.PressKeys("C:\\UltraEditFiles\\ue-20241025T061201Z-006\\ue\\encodingTestsBOM\\langFile_ASCII_UNIX.txt");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.ButtonOpen' at 18;13.", repo.Open.ButtonOpenInfo, new RecordItemIndex(3));
            //repo.Open.ButtonOpen.Click("18;13");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Select() on item 'UltraEdit64Bit.Advanced'.", repo.UltraEdit64Bit.AdvancedInfo, new RecordItemIndex(4));
            repo.UltraEdit64Bit.Advanced.Select();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'UltraEdit64Bit.Settings' at 8;51.", repo.UltraEdit64Bit.SettingsInfo, new RecordItemIndex(5));
            repo.UltraEdit64Bit.Settings.Click("8;51");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Configuration.FileHandling' at 59;3.", repo.Configuration.FileHandlingInfo, new RecordItemIndex(6));
            repo.Configuration.FileHandling.Click("59;3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Configuration.Conversions' at 41;9.", repo.Configuration.ConversionsInfo, new RecordItemIndex(7));
            repo.Configuration.Conversions.Click("41;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Configuration.UseIBM500StandardForEBCDICConversi' at 10;12.", repo.Configuration.UseIBM500StandardForEBCDICConversiInfo, new RecordItemIndex(8));
            repo.Configuration.UseIBM500StandardForEBCDICConversi.Click("10;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='False') on item 'Configuration.UseIBM500StandardForEBCDICConversi'.", repo.Configuration.UseIBM500StandardForEBCDICConversiInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.Configuration.UseIBM500StandardForEBCDICConversiInfo, "Checked", "False");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Configuration.Close' at 25;11.", repo.Configuration.CloseInfo, new RecordItemIndex(10));
            repo.Configuration.Close.Click("25;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Select() on item 'UltraEdit64Bit.Advanced'.", repo.UltraEdit64Bit.AdvancedInfo, new RecordItemIndex(11));
            repo.UltraEdit64Bit.Advanced.Select();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormCUltraEditFilesUe20241025T06120.Conversions' at 90;9.", repo.FormCUltraEditFilesUe20241025T06120.ConversionsInfo, new RecordItemIndex(12));
            repo.FormCUltraEditFilesUe20241025T06120.Conversions.Click("90;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Uedit64.ASCIIToEBCDIC' at 83;12.", repo.Uedit64.ASCIIToEBCDICInfo, new RecordItemIndex(13));
            repo.Uedit64.ASCIIToEBCDIC.Click("83;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{F12}' with focus on 'FormCUltraEditFilesUe20241025T06120'.", repo.FormCUltraEditFilesUe20241025T06120.SelfInfo, new RecordItemIndex(14));
            repo.FormCUltraEditFilesUe20241025T06120.Self.EnsureVisible();
            Keyboard.Press("{F12}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'nonibm500.txt' with focus on 'SaveAs.Text1001'.", repo.SaveAs.Text1001Info, new RecordItemIndex(15));
            repo.SaveAs.Text1001.PressKeys("nonibm500.txt");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SaveAs.ButtonSave' at 22;17.", repo.SaveAs.ButtonSaveInfo, new RecordItemIndex(16));
            repo.SaveAs.ButtonSave.Click("22;17");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
