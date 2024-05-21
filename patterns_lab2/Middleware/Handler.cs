namespace Middleware;

//абстрактный базовый класс для обработчиков, реализует интерфейс IHandler
public abstract class Handler : IHandler {
    //хранит ссылку на следующий обработчик в цепочке
    private IHandler _nextHandler;

    //устанавливает следующий обработчик
    public IHandler SetNext(IHandler handler) {
        _nextHandler = handler;
        return handler;
    }

    //выполняет обработку запроса и передает следующему обработчику
    public virtual void Handle(string request) {        
        _nextHandler?.Handle(request);
    }

}