namespace DocumentModel.Drawings;
/// <summary>
///   Represents a collection of adjustment points for 2D drawing commands.
/// </summary>
[OpenXmlType(typeof(AdjustPoint2DType))]
[DataContract]
[XmlRoot("AdjustPoints", Namespace = "DocumentModel.Drawings")]
public class AdjustPoints : ElementCollection<AdjustPoint2DType>
{
}