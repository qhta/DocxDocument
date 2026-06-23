namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Defines the OpenXmlSolidColorFillPropertiesElement Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.OpenXmlSolidColorFillPropertiesElement))]
[XmlRoot("OpenXmlSolidColorFillPropertiesElement", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class OpenXmlSolidColorFillPropertiesElement : ModelElement<DXO16DCD.OpenXmlSolidColorFillPropertiesElement>
{
  /// <summary>
  /// Color.
  /// </summary>
  public ColorType? Color { get => _Color; set => UpdateField(ref _Color, value, nameof(Color)); }
  private ColorType? _Color;
}