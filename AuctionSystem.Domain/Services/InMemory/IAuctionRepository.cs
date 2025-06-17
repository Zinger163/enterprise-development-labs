/// <summary>
/// Интерфейс для работы с данными об аукционах.
/// </summary>
public interface IAuctionRepository
{
    void Add(Auction auction);
    object GetAll();

    /// <summary> Получить аукционы с не проданными зданиями. </summary>
    List<Auction> GetAuctionsWithUnsoldBuildings();

    /// <summary> Получить аукционы по дате. </summary>
    List<Auction> GetByDate(DateTime date);

}