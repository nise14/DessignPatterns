using Composite.Console;
using Composite.Core;

Client client = new Client();

Leaf leaf = new Leaf();
Console.WriteLine("Client: I get a simple component:");
client.ClientCode(leaf);

Composite.Core.Composite tree = new Composite.Core.Composite();
Composite.Core.Composite branch1 = new Composite.Core.Composite();
branch1.Add(new Leaf());
branch1.Add(new Leaf());

Composite.Core.Composite branch2 = new Composite.Core.Composite();
branch2.Add(new Leaf());

tree.Add(branch1);
tree.Add(branch2);

Console.WriteLine("Client: Now I've got a composite tree:");
client.ClientCode(tree);

Console.WriteLine("Client: I don't need to check the components classes even when managing the tree:\n");
client.ClientCode2(tree, leaf);