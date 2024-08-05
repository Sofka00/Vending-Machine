using Vending_Machine;
namespace VendingMachineTest
{
    public class Tests
    {
        [TestFixture]
        public class CoffeMachineTests
        {
            public CoffeMachine _coffeMachine;

            [SetUp]
            public void Setup() 
            {
                _coffeMachine = new CoffeMachine(1, 0, new Dictionary<string, int>());
            }

        
        }
    }
}