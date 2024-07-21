using FileHandler.Services;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Xml.Serialization;
namespace XmlExercise
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            
            XMLService xmlService = new XMLService("quiz.xml");
            int userChoice = 1;
            
            while (userChoice != 0)
            {
                Q_aModel model = new Q_aModel();
                Console.WriteLine("1. Create questions");
                Console.WriteLine("2.Answer Questions");
                userChoice = Convert.ToInt32(Console.ReadLine());
                if (userChoice == 1)
                {
                    Console.WriteLine("Type your question: ");
                    model.question = Console.ReadLine();
                    Console.WriteLine("Type your answer: ");
                    model.answer = Console.ReadLine();
                }
                else if (userChoice == 2)
                {
                   XmlDocument doc = xmlService.ReadXML()!;
                    foreach (XmlNode node in doc)
                    {
                        
                        Console.WriteLine(node);
                    }
                }
                xmlService.CreateNodeFromModel<Q_aModel>(model);
                
            }
            


        }
    }

    
    
}
