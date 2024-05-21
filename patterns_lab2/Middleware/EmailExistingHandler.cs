namespace Middleware;

//обработчик для проверки существования почты в списке
//primary конструктор принимает список существующих почт
public class EmailExistingHandler(HashSet<string> existingEmails) : Handler {
    public override void Handle(string request) {
        string normalizedEmail = request.ToLower();
        if (existingEmails.Contains(normalizedEmail)) {
            Console.WriteLine("Email existence check failed: Email already exists.");
            return;
        }
        Console.WriteLine("Email handler passed successfully.");
        base.Handle(request);
    }
}