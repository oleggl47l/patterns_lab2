using Middleware;

//создание каких-то существующих почт для тестирования
var existingEmails = new HashSet<string> { "test@gmail.com", "sample@gmail.com", "user@gmail.com" };

//создание экземпляров обработчиков
var emailValidationHandler = new EmailValidationHandler();
var emailExistenceHandler = new EmailExistingHandler(existingEmails);
var emailRegistrationHandler = new EmailRegistrationHandler(existingEmails);


//настройка цепочки обработчиков
emailValidationHandler.SetNext(emailExistenceHandler).SetNext(emailRegistrationHandler);

Console.Write("Enter your email: ");
var email = Console.ReadLine();

//обработка электронной почты с помощью цепочки обработчиков
emailValidationHandler.Handle(email);

Console.WriteLine("Current list of emails:");
foreach (var emails in existingEmails) {
    Console.WriteLine(emails);
}