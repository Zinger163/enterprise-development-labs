/// <summary>
/// Реализация репозитория покупателей (InMemory-хранилище).
/// </summary>
public class BuyerRepository : IBuyerRepository
{
    private readonly List<Buyer> _buyers = new List<Buyer>();

    public List<Buyer> GetAll() => _buyers;
    public Buyer GetById(int id) => _buyers.FirstOrDefault(b => b.Id == id);
    public void Add(Buyer buyer) => _buyers.Add(buyer);
}
//  
