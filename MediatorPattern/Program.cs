using MediatorPattern;

class Program
{
    static void Main()
    {
        Mediator mediator = new Mediator();

        Colleague userCarlos = new User(mediator);
        Colleague userAdmin = new UserAdmin(mediator);
        Colleague userAdmin2 = new UserAdmin(mediator);

        mediator.Add(userCarlos);
        mediator.Add(userAdmin);
        mediator.Add(userAdmin2);

        userCarlos.Communicate("Algun admin en la sala?");
        userAdmin.Communicate("Si, yo!");
        
    }
}