using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;

namespace Syringe_app
{
    class SyringesBaseConnector
    {
        string path = ConfigurationManager.AppSettings.Get("CSV_Path");
        private static SyringesBaseConnector instance = null;

        #region CREATE CSV-BASE CONNECTOR
        /// <summary>
        /// Constructor.
        /// </summary>
        private SyringesBaseConnector()
        {
            if (!File.Exists(path))
            {
                string row = "ID; Syringe name; Syringe volume[ml]; Suringe length[step]; Syringe start position[step]";
                File.Create(path);
                File.WriteAllText(path,row);
            }
        }

        /// <summary>
        /// Methods to return instance of class. 
        /// </summary>
        /// <returns>
        /// Instance of SyringeBaseConnector instance.
        /// </returns>
        public static SyringesBaseConnector getInstance()
        {
            if (instance == null)
            {
                instance = new SyringesBaseConnector();
            }
            return instance;
        }
        #endregion

        #region WRITE/READ FROM CSV
        /// <summary>
        /// Read all lines from CSV file.
        /// </summary>
        /// <returns>
        /// List of Syringe objects.
        /// </returns>
        public List<Syringe> getSyringes()
        {
            return File.ReadAllLines(path)
                .Skip(1)
                .Where(row => row.Length > 0)
                .Select(Syringe.parseRow).ToList();
        }
        
        /// <summary>
        /// Add new Syringe.
        /// Write to CSV all values of new Syringe.
        /// </summary>
        /// <param Syringe object = "syringe"></param>
        /// <returns>
        /// return true if write, false if raise exception.
        /// </returns>
        public bool addSyringe(Syringe syringe)
        {
            try
            {
                using(StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(string.Format("\n{0};{1};{2};{3};{4}", syringe.ID, syringe.name, syringe.volume, syringe.length, syringe.start_pos));
                    sw.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}
