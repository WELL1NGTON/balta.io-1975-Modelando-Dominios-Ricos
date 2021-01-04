using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Handlers;
using PaymentContext.Tests.Mocks;

namespace PaymentContext.Tests
{
    [TestClass]
    class SubscriptionHandlerTests
    {


        [TestMethod]
        void ShouldReturnErrorWhenDocumentExists()
        {
            var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
            var command = new CreateBoletoSubscriptionCommand();

            command.FirstName = "Bruce";
            command.LastName = "Wayne";
            command.Document = "99999999999";
            command.Email = "hello@balta.io2";

            command.BarCode = "123456789";
            command.BoletoNumber = "123123";
            command.PaymentNumber = "123123";
            command.PaidDate = DateTime.Now;
            command.ExpireDate = DateTime.Now;
            command.Total = 60;
            command.TotalPaid = 60;
            command.Payer = "WAYNE CORP";
            command.PayerDocument = "12345678911";
            command.PayerDocumentType = Domain.Enums.EDocumentType.CPF;
            command.PayerEmail = "batman@dc.com";

            command.Street = "aaasdfdf";
            command.Number = "asdfasdf";
            command.Neighborhood = "asfasdf";
            command.City = "asdfasdf";
            command.State = "asdfasdf";
            command.Country = "afdsfasdf";
            command.ZipCode = "12345678";

            handler.Handle(command);

            Assert.AreEqual(false, handler.Valid);
        }

    }
}