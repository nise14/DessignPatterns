using Command.Core;

Invoker invoker = new Invoker();
invoker.SetOnStart(new SimpleCommand("Say Hi!"));
Receiver receiver = new Receiver();
invoker.SetOnFinish(new Complexcommand(receiver, "Send email", "Save report"));

invoker.DoSomethingImportant();