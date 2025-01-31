namespace DecoratorNS;

internal class Program
{
    static void Main(string[] args)
    {
        var message = new Message();
        var deco1 = new FacebookDecorator(message);
        var deco2 = new TwitterDecorator(deco1);

        var deco22 = new TwitterDecorator(new FacebookDecorator(new Message()));

        deco2.Send("Hello");
        deco22.Send("World");
    }
}