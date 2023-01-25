namespace Mediator.Core;
public interface IMediator
{
    void Notify(object sender, string ev);
}
