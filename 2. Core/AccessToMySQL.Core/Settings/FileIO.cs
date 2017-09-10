using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using AccessToMySQL.Infrastructure.Tools;

namespace AccessToMySQL.Core.Settings
{
    public class FileIO
    {

        /// <summary>
        /// Méthode renvoie la liste de fichiers dans un repertoire sous un extension donnée
        /// </summary>
        /// <returns></returns>
        public FileInfo[] ReadFromDirectory(string folderPath, string extension)
        {
            try
            {
                //// Get the path from the Application Config 
                DirectoryInfo directory = new DirectoryInfo(folderPath);
                return directory.GetFiles("*." + extension);
            }
            catch (Exception ex)
            {

                Logger.LogMessage(ex.Message, TraceType.Error);
                return null;
            }
        }


        /// <summary>
        /// Write a file
        /// </summary>
        /// <param name="textToWrite"></param>
        public static void WriteToFile(string textToWrite, string fileName, string FolderPath, string exentension)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(FolderPath + "\\" + fileName + "." + exentension))
                {
                    file.Write(textToWrite);
                }
            }
            catch (Exception ex)
            {

                Logger.LogMessage(ex.Message, TraceType.Error);
            }
        }

        /// <summary>
        /// Méthode renvoie la liste des segments (sous forme de string) à partir d'un fichier H'
        /// </summary>
        /// <param name="file"></param>
        /// <param name="separateur"></param>
        /// <returns></returns>
        public List<string> ExtractLinesFromFile(FileInfo file, string marqueFin)
        {

            StreamReader streamFile = null;
            List<string> listLines = new List<string>();
            try
            {
                streamFile = File.OpenText(file.FullName);
                string line = string.Empty;
                while (!(line = streamFile.ReadLine()).Contains(marqueFin))
                {
                    if (!string.IsNullOrEmpty(line))
                        listLines.Add(line);
                }
            }
            catch (Exception ex)
            {
                Logger.LogMessage(ex.Message, TraceType.Error);
            }
            finally
            {
                streamFile.Close();
            }
            return listLines;
        }

        /// <summary>
        /// Méthode renvoie la liste des segments (sous forme de string) à partir d'un fichier H'
        /// </summary>
        /// <param name="file"></param>
        /// <param name="separateur"></param>
        /// <returns></returns>
        public List<string> ExtractLinesFromFile(FileInfo file)
        {

            StreamReader streamFile = null;
            List<string> listLines = new List<string>();
            try
            {
                streamFile = File.OpenText(file.FullName);
                string line = string.Empty;
                while (!string.IsNullOrEmpty(line = streamFile.ReadLine()))
                {
                    if (!string.IsNullOrEmpty(line))
                        listLines.Add(line);
                }
            }
            catch (Exception ex)
            {
                Logger.LogMessage(ex.Message, TraceType.Error);
            }
            finally
            {
                streamFile.Close();
            }
            return listLines;
        }

        public void CatFileFolder(FileInfo file, string folderPath)
        {
            try
            {

                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);
                string destinationFileName = folderPath + "/" + file.Name;
                File.Copy(file.FullName, destinationFileName, true);
                File.Delete(file.FullName);


            }
            catch (Exception ex)
            {

                Logger.LogMessage(ex.Message, TraceType.Error);
            }
        }
    }
}
