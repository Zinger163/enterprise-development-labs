/// <summary>
/// Интерфейс для работы с данными о покупателях.
/// </summary>
public interface IBuyerRepository
{
    /// <summary> Получить всех покупателей. </summary>
    List<Buyer> GetAll();

    /// <summary> Найти покупателя по ID. </summary>
    Buyer GetById(int id);

    /// <summary> Добавить нового покупателя. </summary>
    void Add(Buyer buyer);
}