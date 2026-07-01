namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of levels in a multi-level string cache.
/// </summary>
[DataContract]
[XmlRoot("Levels", Namespace = "DocumentModel.Drawings.Charts")]
public class Levels : ModelElementCollection<Level>
{
}