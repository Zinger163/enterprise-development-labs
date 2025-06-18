/// <summary>
/// Класс, описывающий здание, выставляемое на аукцион.
/// </summary>
public class Building
{
    /// <summary> Уникальный идентификатор здания. </summary>
    public int Id { get; set; }

    /// <summary> Адрес здания. </summary>
    public string Address { get; set; }

    /// <summary> Район города (из перечисления District). </summary>
    public District District { get; set; }

    /// <summary> Тип фонда (жилой/нежилой). </summary>
    public BuildingType Type { get; set; }

    /// <summary> Начальная цена. </summary>
    public decimal InitialPrice { get; set; }

    /// <summary> Финальная цена (если продано). </summary>
    public decimal? FinalPrice { get; set; }

    /// <summary> ID покупателя (если продано). </summary>
    public int? BuyerId { get; set; }
}
// 
