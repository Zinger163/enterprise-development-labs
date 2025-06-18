namespace AuctionSystem.Domain.Tests.Repositories
{
    public class AuctionRepositoryTests
    {
        [Fact]
        public void GetAuctionsWithUnsoldBuildings_ShouldReturnOnlyAuctionsWithUnsoldBuildings()
        {
            // Arrange
            var repo = new AuctionRepository();
            var auctionWithUnsold = new Auction
            {
                Buildings = new List<Building>
                {
                    new Building { BuyerId = null }
                }
            };
            var auctionWithSold = new Auction
            {
                Buildings = new List<Building>
                {
                    new Building { BuyerId = 1 }
                }
            };

            repo.Add(auctionWithUnsold);
            repo.Add(auctionWithSold);

            // Act
            var result = repo.GetAuctionsWithUnsoldBuildings();

            // Assert
            Assert.Single(result);
            Assert.Contains(auctionWithUnsold, result);
            Assert.DoesNotContain(auctionWithSold, result);
        }
    }
}

