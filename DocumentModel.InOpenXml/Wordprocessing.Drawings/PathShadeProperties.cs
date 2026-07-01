namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents the properties for a path-based gradient shade applied to a drawing element in a Wordprocessing document.
/// This class provides configuration for the gradient path type and the rectangle area to which the fill is applied, enabling advanced gradient effects and precise control over fill positioning.
/// </summary>
[OpenXmlType(typeof(DXO10W.PathShadeProperties))]
[DataContract]
[XmlRoot("PathShadeProperties", Namespace = "DocumentModel.Wordprocessing.Drawings")]
public partial class PathShadeProperties : ModelElement<DXO10W.PathShadeProperties>
{
 /// <summary>
 /// The type of path used for the gradient shade, specifying the shape and direction of the gradient fill.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.PathShadeProperties.Path))]
 public DMD.PathShade? Path { get => _Path; set => UpdateField(ref _Path, value, nameof(Path)); }
 private DMD.PathShade? _Path;

 /// <summary>
 /// The rectangle area to which the gradient fill is applied, allowing precise definition of the fill boundaries.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.PathShadeProperties.FillToRectangle))]
 public FillToRectangle? FillToRectangle { get => _FillToRectangle; set => UpdateField(ref _FillToRectangle, value, nameof(FillToRectangle)); }
 private FillToRectangle? _FillToRectangle;
}