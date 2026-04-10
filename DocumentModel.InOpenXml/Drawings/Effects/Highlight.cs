namespace DocumentModel.Drawings;
/// <summary>
///   Defines the Highlight class.
/// </summary>
[OpenXmlType(typeof(DXD.Highlight))]
[XmlRoot("Highlight", Namespace = "DocumentModel.Drawings")]
public class Highlight : ModelElement<DXD.Highlight>
{
  /// <summary>
  ///   Highlight color.
  /// </summary>
  public AnyColor? Color { get => _Color; set => UpdateField(ref _Color, value, nameof(Color)); }
  private AnyColor? _Color;
}