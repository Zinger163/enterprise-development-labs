namespace AuctionSystem.Domain.Tests.Repositories
{
    public class BuyerRepositoryTests
    {
        [Fact]
        public void AddBuyer_ShouldAddBuyerToRepository()
        {
            // Arrange
            var repo = new BuyerRepository();
            var buyer = new Buyer { Id = 1, FullName = "Иванов И.И." };

            // Act
            repo.Add(buyer);
            var result = repo.GetById(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Иванов И.И.", result.FullName);
        }

        [Fact]
        public void GetById_ShouldReturnNullForNonExistentId()
        {
            // Arrange
            var repo = new BuyerRepository();

            // Act
            var result = repo.GetById(999);

            // Assert
            Assert.Null(result);
        }
    }
}