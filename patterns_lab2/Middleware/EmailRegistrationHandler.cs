namespace Middleware;

//обработчик для регистрации почты (добавления в список)
public class EmailRegistrationHandler(HashSet<string> existingEmails) : Handler {
    public override void Handle(string request) {
        existingEmails.Add(request.ToLower());
        Console.WriteLine($"Email '{request}' has been successfully registered.");
        base.Handle(request);
    }
}