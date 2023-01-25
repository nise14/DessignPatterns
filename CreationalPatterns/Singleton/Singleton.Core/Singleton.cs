namespace Singleton.Core;
public sealed class Singleton
{
    private Singleton(){}

    private static Singleton _instance;

    public static Singleton GetInstance(){
        if(_instance==null){
            _instance=new Singleton();
        }

        return _instance;
    }

    public string SomeBusinessLogic(){
        return "Put your logic here...";
    }
}
