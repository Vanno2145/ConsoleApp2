using System;

class Program
{

   public abstract class Device
    {
        virtual public void Sound() { }
        virtual public void Show() { }
        virtual public void Desc() { }
    }

    class Car : Device
    {
        public string name { get; set; }
        public string description { get; set; }

        public Car()
        {
            name = string.Empty;
            description = string.Empty;
        }
        public Car(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public override void Sound()
        {
            Console.WriteLine("Car!");
        }
        public override void Show()
        {
            Console.WriteLine(name);
        }
        public override void Desc()
        {
            Console.WriteLine(description);
        }

    }

    class Kettle : Device
    {
        public string name { get; set; }
        public string description { get; set; }

        public Kettle()
        {
            name = string.Empty;
            description = string.Empty;
        }
        public Kettle(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public override void Sound()
        {
            Console.WriteLine("Kettle!");
        }
        public override void Show()
        {
            Console.WriteLine(name);
        }
        public override void Desc()
        {
            Console.WriteLine(description);
        }

    }

    class Microwave : Device
    {
        public string name { get; set; }
        public string description { get; set; }

        public Microwave()
        {
            name = string.Empty;
            description = string.Empty;
        }
        public Microwave(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public override void Sound()
        {
            Console.WriteLine("Microwave!");
        }
        public override void Show()
        {
            Console.WriteLine(name);
        }
        public override void Desc()
        {
            Console.WriteLine(description);
        }
    }

    class Steamboat : Device
    {
        public string name { get; set; }
        public string description { get; set; }

        public Steamboat()
        {
            name = string.Empty;
            description = string.Empty;
        }
        public Steamboat(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public override void Sound()
        {
            Console.WriteLine("Steamboat!");
        }
        public override void Show()
        {
            Console.WriteLine(name);
        }
        public override void Desc()
        {
            Console.WriteLine(description);
        }
    }

    public abstract class MusicalInstrument
    {
        public abstract void Sound();
        public abstract void Show();
        public abstract void Desc();
        public abstract void History();
    }

    class Violin : MusicalInstrument
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Violin(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public override void Sound()
        {
            Console.WriteLine("Violin sound!");
        }

        public override void Show()
        {
            Console.WriteLine(Name);
        }

        public override void Desc()
        {
            Console.WriteLine(Description);
        }

        public override void History()
        {
            Console.WriteLine("The violin has a history dating back to the 16th century in Italy.");
        }
    }

    class Trombone : MusicalInstrument
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Trombone(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public override void Sound()
        {
            Console.WriteLine("Trombone sound!");
        }

        public override void Show()
        {
            Console.WriteLine(Name);
        }

        public override void Desc()
        {
            Console.WriteLine(Description);
        }

        public override void History()
        {
            Console.WriteLine("The trombone was developed in the 15th century and is part of the brass family.");
        }
    }

    class Ukulele : MusicalInstrument
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Ukulele(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public override void Sound()
        {
            Console.WriteLine("Ukulele sound!");
        }

        public override void Show()
        {
            Console.WriteLine(Name);
        }

        public override void Desc()
        {
            Console.WriteLine(Description);
        }

        public override void History()
        {
            Console.WriteLine("The ukulele originated in Hawaii in the 19th century, based on Portuguese instruments.");
        }
    }

    class Cello : MusicalInstrument
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Cello(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public override void Sound()
        {
            Console.WriteLine("Cello sound!");
        }

        public override void Show()
        {
            Console.WriteLine(Name);
        }

        public override void Desc()
        {
            Console.WriteLine(Description);
        }

        public override void History()
        {
            Console.WriteLine("The cello was developed in the early 16th century in Italy and is a member of the violin family.");
        }
    }

    public abstract class Worker
    {
        public abstract void Print();
    }

    class President : Worker
    {
        public override void Print()
        {
            Console.WriteLine("President: Responsible for overseeing the entire organization.");
        }
    }

    class Security : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Security: Ensures the safety and security of the organization and its employees.");
        }
    }

    class Manager : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Manager: Manages teams and coordinates projects within the organization.");
        }
    }

    class Engineer : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Engineer: Responsible for technical and engineering tasks within the organization.");
        }
    }


    static void Main(string[] args)
    {
        
    }    
}


