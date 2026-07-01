namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of pie chart series extensions.
/// </summary>
[DataContract]
[XmlRoot("PieSerExtensionList", Namespace = "DocumentModel.Drawings.Charts")]
public class PieSerExtensionList : ModelElementCollection<PieSerExtension>
{
}