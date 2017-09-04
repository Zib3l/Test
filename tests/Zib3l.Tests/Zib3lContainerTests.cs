using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Zib3l.Tests
{
    class Zib3lContainerTests
    {
        [Fact]
        public void resolves_registred_components()
        {
            //Arrange
            var container = new Zib3lContainer();
            container.Register<ITestInterface, TestImplementation>();
            //Act
            var resolvedObj = container.Resolve<ITestInterface>();

            //Assert
            resolvedObj.ShouldBeOfType<TestImplementation>();
        }
        public interface ITestInterface
        {

        }

        public class TestImplementation : ITestInterface
        {


        }
    }
}
