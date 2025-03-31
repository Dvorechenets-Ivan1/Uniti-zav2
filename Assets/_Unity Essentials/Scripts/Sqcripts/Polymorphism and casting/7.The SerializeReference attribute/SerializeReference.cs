using UnityEngine;
public class PetShop : MonoBehaviour
{
   [SerializeReference]
   public Mammal mammal = new Cat();
}
public class Animal
{}
[Serializable]
public class Mammal : Animal
{}
public class Cat : Mammal
{}