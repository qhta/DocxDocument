namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of stock chart extensions.
/// </summary>
[DataContract]
[XmlRoot("StockChartExtensionList", Namespace = "DocumentModel.Drawings.Charts")]
public class StockChartExtensionList : ModelElementCollection<StockChartExtension>
{
}