/// <summary>
/// Реализация репозитория аукционов (InMemory-хранилище).
/// </summary>
public class AuctionRepository : IAuctionRepository
{
    private readonly List<Auction> _auctions = new List<Auction>();

    /// <summary> Добавляет аукцион в хранилище. </summary>
    public void Add(Auction auction) => _auctions.Add(auction);

    /// <summary> Получает все аукционы. </summary>
    public List<Auction> GetAll() => _auctions;

    /// <summary> Получает аукционы с не проданными зданиями. </summary>
    public List<Auction> GetAuctionsWithUnsoldBuildings() =>
        _auctions.Where(a => a.Buildings.Any(b => b.BuyerId == null)).ToList();

    /// <summary> Получает аукционы по указанной дате. </summary>
    public List<Auction> GetByDate(DateTime date) =>
        _auctions.Where(a => a.Date.Date == date.Date).ToList();

    object IAuctionRepository.GetAll()
    {
        return GetAll();
    }

    List<Auction> IAuctionRepository.GetAuctionsWithUnsoldBuildings()
    {
        throw new NotImplementedException();
    }
// 
    List<Auction> IAuctionRepository.GetByDate(DateTime date)
    {
        throw new NotImplementedException();
    }
}
