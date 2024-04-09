using System;
using System.Text;

namespace ChemistryThing
{
    public static class Program
    {
        //Made to help study for Chemistry


        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(NamingElements.CreateIonic(Elements.data[32], Elements.data[42]));
            Console.WriteLine(NamingElements.CreateIonic(Elements.data[20], Elements.data[0]));
            Console.WriteLine(NamingElements.CreateIonic(Elements.data[16], Elements.data[13]));
            Console.WriteLine(NamingElements.CreateMolecular(Elements.data[4], Elements.data[0]));
            Console.WriteLine(NamingElements.CreateMolecular(Elements.data[6], Elements.data[0]));
            Console.WriteLine(NamingElements.CreateMolecular(Elements.data[4], Elements.data[46]));
            Console.WriteLine(NamingElements.CreateMolecular(Elements.data[6], Elements.data[43]));
            Console.WriteLine(NamingElements.CreateMolecular(Elements.data[13], Elements.data[48]));

            IonicMolucule ionicMol = NamingElements.CreateIonic(Elements.data[32], Elements.data[42]);
            Console.WriteLine(Reactions.SingleDisplacement(Elements.data[0], ionicMol));

            ionicMol = NamingElements.CreateIonic(Elements.data[20], Elements.data[0]);
            Console.WriteLine(Reactions.SingleDisplacement(Elements.data[32], ionicMol));

            ionicMol = NamingElements.CreateIonic(Elements.data[20], Elements.data[7]);
            Console.WriteLine(Reactions.SingleDisplacement(Elements.data[34], ionicMol));

            MolecularMolucule molecularMol = NamingElements.CreateMolecular(Elements.data[4], Elements.data[0]);
            Console.WriteLine(Reactions.SingleDisplacement(Elements.data[5], molecularMol));

            molecularMol = NamingElements.CreateMolecular(Elements.data[4], Elements.data[0]);
            Console.WriteLine(Reactions.SingleDisplacement(Elements.data[34], molecularMol));

            molecularMol = NamingElements.CreateMolecular(Elements.data[4], Elements.data[7]);
            Console.WriteLine(Reactions.SingleDisplacement(Elements.data[34], molecularMol));


            Console.ReadLine();
        }
    }
}