/// <summary>
/// Класс, представляющий аукцион по продаже зданий.
/// </summary>
public class Auction
{
    /// <summary> Уникальный идентификатор аукциона. </summary>
    public int Id { get; set; }

    /// <summary> Дата и время проведения. </summary>
    public DateTime Date { get; set; }

    /// <summary> Список зданий-лотов. </summary>
    public List<Building> Buildings { get; set; } = new List<Building>();

    /// <summary> Статус завершения аукциона. </summary>
    public bool IsCompleted { get; set; }
}
//By Zinger16333
