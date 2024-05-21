namespace Middleware;

//интерфейс IHandler для обработчиков, определяет метод установки следующего обработчика и метод обработки запроса
public interface IHandler {
    IHandler SetNext(IHandler handler);
    void Handle(string request);
}