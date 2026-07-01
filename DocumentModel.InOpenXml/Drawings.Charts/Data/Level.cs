namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a level in a multi-level string cache, containing string points.
/// </summary>
[OpenXmlType(typeof(DXDC.Level))]
[DataContract]
[XmlRoot("Level", Namespace = "DocumentModel.Drawings.Charts")]
public partial class Level : ModelElementCollection<StringPoint, DXDC.Level, DXDC.StringPoint>
{
}