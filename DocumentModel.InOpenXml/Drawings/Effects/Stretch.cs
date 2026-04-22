namespace DocumentModel.Drawings;
/// <summary>
///   Represents a stretch effect, specifying a fill rectangle for stretching content within a shape or element.
/// </summary>
[OpenXmlType(typeof(DXD.Stretch))]
[XmlRoot("Stretch", Namespace = "DocumentModel.Drawings")]
public partial class Stretch : ModelElement<DXD.Stretch>
{
 /// <summary>
 ///   Rectangle that defines the area to fill when stretching content.
 /// </summary>
 public RelativeRectangleType? FillRectangle { get => _FillRectangle; set => UpdateField(ref _FillRectangle, value, nameof(FillRectangle)); }
 private RelativeRectangleType? _FillRectangle;
}