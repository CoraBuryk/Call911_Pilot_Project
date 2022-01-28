using Project.Log;
using System;
using System.IO;

namespace Chat
{
    public class TemporaryAttribute : Attribute
    {
        public static void DeleteTmpFile(string tmpFile)
        {
            Logger<TemporaryAttribute> logger = new Logger<TemporaryAttribute>();
            try
            {
                // Delete the temp file (if it exists)
                if (File.Exists(tmpFile))
                {
                    File.Delete(tmpFile);
                    logger.Info("TEMP file deleted.");
                }
            }
            catch (Exception ex)
            {
                logger.Info("Error deleteing TEMP file: " + ex.Message);
            }
        }
    }
}