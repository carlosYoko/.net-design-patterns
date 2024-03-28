using MediatorPattern;

class Program
{
    static void Main()
    {
        Mediator mediator = new Mediator();

        Colleague user1 = new User(mediator, "Carlos");
        Colleague userAdmin1 = new UserAdmin(mediator, "Pajaro Loco");
        Colleague userAdmin2 = new UserAdmin(mediator, "Robert C");

        mediator.Add(user1);
        mediator.Add(userAdmin1);
        mediator.Add(userAdmin2);

        user1.Communicate("Algun admin en la sala?");
        userAdmin1.Communicate("Si, yo! Soy Pajaro Loco!");
        
    }
}