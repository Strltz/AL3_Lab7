using System;
using System.Reflection;
using System.Xml.Linq;
using Lab7;


XDocument document = new XDocument();

// Lion
Console.WriteLine("Enter the Lion:");
Lion animal = new Lion();
Type typeAnimal = typeof(Lion);

XElement the_animal_name = new XElement(typeAnimal.Name);
XAttribute commentAttr = new XAttribute("comment", "It is lion");
the_animal_name.Add(commentAttr);

PropertyInfo[] properties = typeAnimal.GetProperties(); // массив свойств
foreach (PropertyInfo property in properties)
{
    XElement element = new XElement(property.Name);
    Console.WriteLine($"Enter {property.Name}");
    string str_prop = Console.ReadLine();
    the_animal_name.Add(element, str_prop);
}

XElement base1 = new XElement("base");
base1.Add(the_animal_name);
Console.WriteLine();

// Pig
Console.WriteLine("Enter the Pig:");
Pig animal2 = new Pig();
typeAnimal = typeof(Pig);

XElement the_animal_name2 = new XElement(typeAnimal.Name);
XAttribute commentAttr2 = new XAttribute("comment", "It is pig");
the_animal_name2.Add(commentAttr2);

PropertyInfo[] properties2 = typeAnimal.GetProperties();
foreach (PropertyInfo property in properties2)
{
    XElement element = new XElement(property.Name);
    Console.WriteLine($"Enter {property.Name}");
    string str_prop = Console.ReadLine();
    the_animal_name2.Add(element, str_prop);
}

base1.Add(the_animal_name2);
Console.WriteLine();

// MyAttribute
Console.WriteLine("Enter the attribute:");
MyAttribute attrib = new MyAttribute("This is my attribute");
Type type_attrib = typeof(MyAttribute);

XElement the_attrib = new XElement(type_attrib.Name);
XAttribute commentMyAttr3 = new XAttribute("comment", "Attribute");
the_attrib.Add(commentMyAttr3);

PropertyInfo[] properties3 = type_attrib.GetProperties();
foreach (PropertyInfo property in properties3)
{
    XElement element = new XElement(property.Name);
    Console.WriteLine($"Enter {property.Name}");
    string str_prop = Console.ReadLine();
    the_attrib.Add(element, str_prop);
}

base1.Add(the_attrib);

document.Add(base1);

document.Save("the_file2.xml");
