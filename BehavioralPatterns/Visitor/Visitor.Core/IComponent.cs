namespace Visitor.Core;
public interface IComponent
{
    void Accept(IVisitor visitor);
}
