namespace DocumentModel.Drawings;
/// <summary>
///   Represents a reference to a line style, including style matrix index and color information in multiple color models.
/// </summary>
[OpenXmlType(typeof(DXD.LineReference))]
[XmlRoot("LineReference", Namespace = "DocumentModel.Drawings")]
public partial class LineReference : ModelElement<DXD.LineReference>
{
 /// <summary>
 ///   Index into the style matrix for the line style.
 /// </summary>
 public int StyleMatrixIndex { get => _StyleMatrixIndex; set => UpdateField(ref _StyleMatrixIndex, value, nameof(StyleMatrixIndex)); }
 private int _StyleMatrixIndex;

 /// <summary>
 ///   Line color specified using the RGB color model with percentage values.
 /// </summary>
 public ColorType? Color { get => _Color; set => UpdateField(ref _Color, value, nameof(Color)); }
 private ColorType? _Color;

}