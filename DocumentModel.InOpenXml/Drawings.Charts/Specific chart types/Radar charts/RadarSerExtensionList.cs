namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of radar chart series extensions.
/// </summary>
[DataContract]
[XmlRoot("RadarSerExtensionList", Namespace = "DocumentModel.Drawings.Charts")]
public class RadarSerExtensionList : ModelElementCollection<RadarSerExtension>
{
}