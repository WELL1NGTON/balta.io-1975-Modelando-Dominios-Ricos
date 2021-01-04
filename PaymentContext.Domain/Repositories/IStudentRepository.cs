using PaymentContext.Domain.Entities;

namespace PaymentContext.Domain.Repositories
{
    // Repository Pattern
    // Não vamos fazer implementação nesse curso
    // "Se quiserem ver algumas implementações, peguem o curso Modern Web Apps"
    public interface IStudentRepository
    {
        bool DocumentExists(string document);
        bool EmailExists(string email);
        void CreateSubscription(Student student);
    }
}