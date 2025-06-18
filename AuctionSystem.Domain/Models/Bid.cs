/// <summary>
/// Класс, представляющий ставку покупателя на аукционе.
/// </summary>
public class Bid
{
    /// <summary> Уникальный идентификатор ставки. </summary>
    public int Id { get; set; }

    /// <summary> ID аукциона. </summary>
    public int AuctionId { get; set; }

    /// <summary> ID покупателя. </summary>
    public int BuyerId { get; set; }

    /// <summary> Сумма ставки. </summary>
    public decimal Amount { get; set; }

    /// <summary> Время подачи ставки. </summary>
    public DateTime Timestamp { get; set; }
}
//
