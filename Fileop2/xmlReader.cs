using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace Fileop2
{
    class xmlReader
    {
        public void Readxml()
        {
            XmlTextReader xmlReader = new XmlTextReader(@"F:\Node_JS & Projects\InputFolder\Students.xml");
            try
            {
                while (xmlReader.Read())
                {
                    if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "Name")
                    {
                        Console.WriteLine("Name : " + xmlReader.ReadElementString());
                    }
                    if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "Age")
                    {
                        Console.WriteLine("Age : " + xmlReader.ReadElementString());
                    }
                    if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "Height")
                    {
                        Console.WriteLine("Height : " + xmlReader.ReadElementString());
                    }
                    if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "Not a property in XML")
                    {
                        Console.WriteLine("Not a property in XML : " + xmlReader.Name);
                    }
                }
                xmlReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Not a correct XML File. Please check the content otherwise Please verify the path is correct or not");
                xmlReader.Close();
            }
            Console.ReadKey();
        }
    }
}
