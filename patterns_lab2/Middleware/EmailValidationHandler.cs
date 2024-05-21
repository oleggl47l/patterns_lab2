using System.Text.RegularExpressions;

namespace Middleware;

//обработчик для проверки формата электронной почты
public class EmailValidationHandler : Handler {
    public override void Handle(string request) {
        if (string.IsNullOrEmpty(request) || !Regex.IsMatch(request, @"^[^@\s]+@[^@\s]+\.[^@\s]+$")) {
            Console.WriteLine("Email validation failed: invalid email format.");
            return;
        }

        Console.WriteLine($"Validation passed: Email '{request}' is correctt.");
        base.Handle(request);
    }
}