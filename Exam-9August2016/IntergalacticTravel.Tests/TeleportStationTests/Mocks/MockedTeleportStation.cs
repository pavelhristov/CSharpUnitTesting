using IntergalacticTravel.Contracts;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntergalacticTravel.Tests.TeleportStationTests.Mocks
{
   class MockedTeleportStation:TeleportStation
   {
   //   var mockedOwned = new Mock<IBusinessOwner>();
   //   var mockedGalacticMap = new Mock<IEnumerable<IPath>>();
   //   var mockedLocation = new Mock<ILocation>();

      public MockedTeleportStation() : base((new Mock<IBusinessOwner>()).Object, (new Mock<IEnumerable<IPath>>()).Object, (new Mock<ILocation>()).Object)
      {
      }
   }
}
