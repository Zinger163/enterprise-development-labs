/// <summary>
/// Класс для заполнения тестовыми данными.
/// </summary>
public static class DataSeeder
{
    /// <summary> Инициализирует репозитории тестовыми данными. </summary>
    public static void Seed(IBuyerRepository buyerRepo, IAuctionRepository auctionRepo)
    {
        // Добавляем покупателей
        buyerRepo.Add(new Buyer
        {
            Id = 1,
            FullName = "Иванов А.А.",
            Phone = "+79001234567",
            Address = "ул. Ленина, 10"
        });

        // Создаем аукцион с зданиями
        var auction = new Auction
        {
            Id = 1,
            Date = new DateTime(2023, 10, 15),
            Buildings = new List<Building>
            {
                new Building
                {
                    Id = 1,
                    Address = "ул. Центральная, 1",
                    District = District.Central,
                    Type = BuildingType.NonResidential,
                    InitialPrice = 5000000
                }
            },
            IsCompleted = false
        };
        auctionRepo.Add(auction);
    }
}
// 
