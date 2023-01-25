namespace ChainOfResponsability.Core;

public class SquirrelHanlder : AbstractHandler
{
    public override object Handle(object request)
    {
        if ((request as string) == "Nut")
        {
            return $"Squirrel: I'll eat the {request.ToString()}.\n";
        }
        else
        {
            return base.Handle(request);
        }
    }
}