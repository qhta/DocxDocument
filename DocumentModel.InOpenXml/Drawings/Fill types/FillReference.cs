namespace DocumentModel.Drawings;
/// <summary>
///   Represents a fill color reference in DrawingML, allowing the specification of a fill color using various color models (RGB, HSL, system, scheme, or preset).
///   Enables advanced color referencing and theming for shapes, lines, and graphical elements in Office documents.
/// </summary>
[OpenXmlType(typeof(DXD.FillReference))]
[DataContract]
[XmlRoot("FillReference", Namespace = "DocumentModel.Drawings")]
public partial class FillReference : ModelElement<DXD.FillReference>
{
  /// <summary>
  ///   Fill color specified using the RGB color model with percentage values for each channel.
  /// </summary>
  public ColorType? Color { get => _Color; set => UpdateField(ref _Color, value, nameof(Color)); }
  private ColorType? _Color;

}