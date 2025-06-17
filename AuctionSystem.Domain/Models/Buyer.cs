/// <summary>
/// Класс, описывающий покупателя (участника аукциона).
/// </summary>
public class Buyer
{
    /// <summary> Уникальный идентификатор. </summary>
    public int Id { get; set; }

    /// <summary> Полное имя (ФИО). </summary>
    public string FullName { get; set; }

    /// <summary> Контактный телефон. </summary>
    public string Phone { get; set; }

    /// <summary> Адрес проживания. </summary>
    public string Address { get; set; }

    /// <summary> Список ставок, сделанных покупателем. </summary>
    public List<Bid> Bids { get; set; } = new List<Bid>();
}