using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;
using System;
using System.Xml.Linq;


namespace lesson8._4
{
    internal class Program
    {
        public void SerializeWorkerList(List<Worker> CreateWorker,string path)
        {
            List<Worker> workerList = new List<Worker>();
                                 
            XmlSerializer serializer = new XmlSerializer(typeof(List<Worker>));

            Stream strem = new FileStream(path, FileMode.Create, FileAccess.Write);

            serializer.Serialize(strem, CreateWorker);            

            strem.Close();

        }
               

        static void Main(string[] args)
        {
            List<Worker> wok = new List<Worker>();

            
            
            
        }
    }
}
