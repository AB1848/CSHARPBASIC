public class AccessModifier
{
    internal void DoSomething()
    {

    }
    public void DoAnotherThing()
    {
        DoSomething();
    }

} 
class ModifierDemo
{
    void DoSomething()
    {
       AccessModifier am = new AccessModifier();
       am.DoSomething();
       Person1 detail = new Person1();
       detail.Age=34;
    }
    
}