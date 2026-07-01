namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of category filter exceptions for a chart.
/// </summary>
[OpenXmlType(typeof(DXO13DC.CategoryFilterExceptions))]
[DataContract]
[XmlRoot("CategoryFilterExceptions", Namespace = "DocumentModel.Drawings.Charts")]
public class CategoryFilterExceptions : ModelElementCollection<CategoryFilterException, DXO13DC.CategoryFilterExceptions, DXO13DC.CategoryFilterException>
{
}