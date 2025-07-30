using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace UltraEditAutomation.Common
{
    /// <summary>
    /// Description of RestoreDefaultSettings.
    /// </summary>
    [TestModule("2F917574-72A0-4ADE-A96E-BD153C793AB2", ModuleType.UserCode, 1)]
    public class RestoreDefaultSettings : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RestoreDefaultSettings()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            var appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var sourceFolder = @"C:\UltraEditDefaultSettings\UltraEdit";
            var destinationFolder = appdata + "\\IDMComp\\UltraEdit";
            
            try
        	{
            	// Check if the destination folder exists
            	if (Directory.Exists(destinationFolder))
	            {
	                // If it exists, delete it first (to replace it)
	                Directory.Delete(destinationFolder, true); // 'true' deletes subfolders and files
	                Report.Log(ReportLevel.Info, "Folder deleted successfully!");
	                Delay.Milliseconds(1000);
	            }
	
	            // Now copy the source folder to the destination
	            CopyDirectory(sourceFolder, destinationFolder);
	
	            Report.Log(ReportLevel.Info, "Folder copied successfully!");
	            Delay.Milliseconds(1000);
	        }
        	catch (Exception ex)
        	{
            	Report.Log(ReportLevel.Info, "An error occurred: " + ex.Message);
        	}
            
        }
        
        // Method to copy a directory (including all subdirectories and files)
	    static void CopyDirectory(string sourceDir, string destinationDir)
	    {
	        // Create the destination directory
	        Directory.CreateDirectory(destinationDir);
	
	        // Get the files in the source directory and copy them to the destination directory
	        foreach (string file in Directory.GetFiles(sourceDir))
	        {
	            string destFile = Path.Combine(destinationDir, Path.GetFileName(file));
	            File.Copy(file, destFile, true); // Overwrite existing files
	        }
	
	        // Copy subdirectories and their contents
	        foreach (string subdir in Directory.GetDirectories(sourceDir))
	        {
	            string destSubDir = Path.Combine(destinationDir, Path.GetFileName(subdir));
	            CopyDirectory(subdir, destSubDir); // Recursive copy
	        }
	    }
    
    }
}
