namespace DocumentModel.Drawings;
/// <summary>
///   Represents a luminance effect, allowing adjustment of brightness and contrast for a drawing element.
/// </summary>
[OpenXmlType(typeof(DXD.LuminanceEffect))]
[DataContract]
[XmlRoot("LuminanceEffect", Namespace = "DocumentModel.Drawings")]
public partial class LuminanceEffect : ModelElement<DXD.LuminanceEffect>
{
  /// <summary>
  ///   Brightness adjustment value.
  /// </summary>
  public Int32? Brightness { get => _Brightness; set => UpdateField(ref _Brightness, value, nameof(Brightness)); }
  private Int32? _Brightness;

  /// <summary>
  ///   Contrast adjustment value.
  /// </summary>
  public Int32? Contrast { get => _Contrast; set => UpdateField(ref _Contrast, value, nameof(Contrast)); }
  private Int32? _Contrast;
}