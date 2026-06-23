namespace DocumentModel.Drawings;
/// <summary>
///   Represents a foreground color, supporting multiple color models for fill formatting.
/// </summary>
[OpenXmlType(typeof(DXD.ForegroundColor))]
[XmlRoot("ForegroundColor", Namespace = "DocumentModel.Drawings")]
public partial class ForegroundColor : ModelElement<DXD.ForegroundColor>
{
 /// <summary>
 ///   Foreground color specified using a preset color.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ForegroundColor.PresetColor))]
 public ColorType? Color { get => _Color; set => UpdateField(ref _Color, value, nameof(Color)); }
 private ColorType? _Color;
}