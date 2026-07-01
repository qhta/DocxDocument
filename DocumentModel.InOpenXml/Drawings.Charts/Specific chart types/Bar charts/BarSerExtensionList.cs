namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of bar chart series extensions.
/// </summary>
[DataContract]
[XmlRoot("BarSerExtensionList", Namespace = "DocumentModel.Drawings.Charts")]
public class BarSerExtensionList : ModelElementCollection<BarSerExtension>
{
}