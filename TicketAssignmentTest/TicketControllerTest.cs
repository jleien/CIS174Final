using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace TicketAssignmentTest
{
    [TestClass]
    public class TicketControllerTest
    {
        [Fact]
        public void TestTicket()
        {
            var mock = new Mock<TicketController>();
            var ticket = new Ticket() { Id=1, Description="test", Name="test1", pointId="5", SprintId="2", StatusId="qa"};
            List<Ticket> list = new List<Ticket>();
            list.Add(ticket);
            
            Assert.AreEqual(1, list.Count) ;

        }
    }
}