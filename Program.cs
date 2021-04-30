using System;

namespace hsubway
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Sandwich sandwichPBJ = new PBJsandwich();
            sandwichPBJ.print();
            sandwichPBJ = new Mayo(sandwichPBJ);
            sandwichPBJ.print();
            sandwichPBJ = new Bacon(sandwichPBJ);
            sandwichPBJ.print();
            sandwichPBJ = new WhiteBread(sandwichPBJ);
            sandwichPBJ.print();

            Sandwich sandwichBLT = new BLTsandwich();
            sandwichBLT.print();

            sandwichBLT = new WhiteBread(sandwichBLT);
            sandwichBLT.print();

            Sandwich sandwichChicken = new BLTsandwich();
            sandwichChicken.print();
            sandwichChicken = new RyeBread(sandwichChicken);
            sandwichChicken.print();






        }
    }

    //sandwich abstract class 
    public abstract class Sandwich
    {
        public string name = " ";
        public abstract double CostFunction();



        public virtual string GetName()
        {
            return this.name;
        }

        public abstract void print();

    }

    public class PBJsandwich : Sandwich
    {

        public PBJsandwich()
        {
            this.name = "PBJ snadwich";
        }


        public override double CostFunction()
        {
            return 0.75;

        }

        public override void print()
        {
            Console.WriteLine(" The " + GetName() + " " + CostFunction());
        }


    }

    public class BLTsandwich : Sandwich
    {
        public BLTsandwich()
        {
            this.name = "BLT snadwich";
        }


        public override double CostFunction()
        {
            return 2.50;

        }

        public override void print()
        {
            Console.WriteLine("The " + GetName() + " " + CostFunction());

        }
    }

    public class Chickensandwich : Sandwich
    {
        public Chickensandwich()
        {
            this.name = "Chicken sandwich";
        }


        public override double CostFunction()
        {
            return 2.50;

        }

        public override void print()
        {
            Console.WriteLine("The " + GetName() + " " + CostFunction());

        }
    }


    //bread class inherits from Sandwich class
    public abstract class Bread : Sandwich
    {


    }


    //Types of breads
    public class WhiteBread : Bread
    {
        Sandwich s;

        public WhiteBread(Sandwich sandy)
        {
            this.s = sandy;
        }
        public override string GetName()
        {
            return this.s.GetName() + " with white bread ";
        }
        public override double CostFunction()
        {
            return 2.00 + s.CostFunction();
        }


        public override void print()
        {
            Console.WriteLine("The " + GetName() + "costs " + CostFunction());

        }


    }

    //jshfd

    public class WheatBread : Bread
    {
        Sandwich s;

        public WheatBread(Sandwich sandy)
        {
            this.s = sandy;
        }
        public override string GetName()
        {
            return this.s.GetName() + " with wheat bread ";
        }
        public override double CostFunction()
        {
            return 2.25 + s.CostFunction();
        }


        public override void print()
        {
            Console.WriteLine("The " + GetName() + "costs " + CostFunction());

        }

    }

    public class RyeBread : Bread
    {
        Sandwich s;

        public RyeBread(Sandwich sandy)
        {
            this.s = sandy;
        }
        public override string GetName()
        {
            return this.s.GetName() + " with Rye bread ";
        }
        public override double CostFunction()
        {
            return 2.00 + s.CostFunction();
        }


        public override void print()
        {
            Console.WriteLine("The " + GetName() + "costs " + CostFunction());

        }

    }


    public abstract class FreeToppings : Sandwich
    {



    }

    public class Mayo : FreeToppings
    {

        Sandwich s;

        public Mayo(Sandwich sandy)
        {
            this.s = sandy;
        }
        public override string GetName()
        {
            return this.s.GetName() + " with Mayo ";
        }
        public override double CostFunction()
        {
            return s.CostFunction();
        }


        public override void print()
        {
            Console.WriteLine("The " + GetName() + "costs " + CostFunction());

        }


    }

    public class Mustard : FreeToppings
    {

        Sandwich s;

        public Mustard(Sandwich sandy)
        {
            this.s = sandy;
        }
        public override string GetName()
        {
            return this.s.GetName() + " with Mustard ";
        }
        public override double CostFunction()
        {
            return s.CostFunction();
        }


        public override void print()
        {
            Console.WriteLine("The " + GetName() + "costs " + CostFunction());

        }


    }

    public class BBQ : FreeToppings
    {

        Sandwich s;

        public BBQ(Sandwich sandy)
        {
            this.s = sandy;
        }
        public override string GetName()
        {
            return this.s.GetName() + " with Mayo ";
        }
        public override double CostFunction()
        {
            return s.CostFunction();
        }


        public override void print()
        {
            Console.WriteLine("The " + GetName() + "costs " + CostFunction());

        }



    }




    public abstract class ExtraToppings : Sandwich
    {



    }

    public class Bacon : ExtraToppings
    {

        Sandwich s;

        public Bacon(Sandwich sandy)
        {
            this.s = sandy;

        }
        public override string GetName()
        {
            return s.GetName() + " and with Bacon ";
        }
        public override double CostFunction()
        {
            return 0.75 + s.CostFunction();
        }


        public override void print()
        {
            Console.WriteLine("The " + GetName() + " costs " + CostFunction());

        }


    }

    public class Ham : ExtraToppings
    {

        Sandwich s;

        public Ham(Sandwich sandy)
        {
            this.s = sandy;

        }
        public override string GetName()
        {
            return s.GetName() + " and with Ham ";
        }
        public override double CostFunction()
        {
            return 0.60 + s.CostFunction();
        }


        public override void print()
        {
            Console.WriteLine("The " + GetName() + " costs " + CostFunction());

        }


    }

    public class Cheese : ExtraToppings
    {
        Sandwich s;

        public Cheese(Sandwich sandy)
        {
            this.s = sandy;

        }
        public override string GetName()
        {
            return s.GetName() + " and with Cheese";
        }
        public override double CostFunction()
        {
            return 0.75 + s.CostFunction();
        }


        public override void print()
        {
            Console.WriteLine("The " + GetName() + " costs " + CostFunction());

        }
    }





    public class Tomato : ExtraToppings
    {
        Sandwich s;

        public Tomato(Sandwich sandy)
        {
            this.s = sandy;

        }
        public override string GetName()
        {
            return s.GetName() + " and with Tomato ";
        }
        public override double CostFunction()
        {
            return 0.25 + s.CostFunction();
        }


        public override void print()
        {
            Console.WriteLine("The " + GetName() + " costs " + CostFunction());

        }



    }

    public class Lettuce : ExtraToppings
    {
        Sandwich s;

        public Lettuce(Sandwich sandy)
        {
            this.s = sandy;

        }
        public override string GetName()
        {
            return s.GetName() + " and with Lettuce ";
        }
        public override double CostFunction()
        {
            return 0.25 + s.CostFunction();
        }


        public override void print()
        {
            Console.WriteLine("The " + GetName() + " costs " + CostFunction());

        }


    }
















}
