public class Mammal
{
   public void GrowFur ()
   {}
}
public class Cat : Mammal
{
   public void Meow ()
   {}
}
public class Dog : Mammal
{
   public void Woof ()
   {}
}
public class RescueShelter
{
   public Mammal[] mammals;
   public RescueShelter ()
   {
       mammals = new Mammal[2];
       mammals[0] = new Cat();
       mammals[1] = new Dog();        
   }
}