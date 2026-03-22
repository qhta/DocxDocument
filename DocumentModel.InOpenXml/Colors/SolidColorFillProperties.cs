namespace DocumentModel;
/// <summary>
///   Defines the SolidColorFillProperties Class.
/// </summary>
[OpenXmlType(typeof(DXO10W.SolidColorFillProperties))]
public partial class SolidColorFillProperties : ModelElement<DXO10W.SolidColorFillProperties>
{
 /// <summary>
 ///   RgbColorModelHex.
 /// </summary>
 public RgbColor? RgbColor { get => _RgbColor; set => UpdateField(ref _RgbColor, value, nameof(RgbColor)); }
 private RgbColor? _RgbColor;
 /// <summary>
 ///   SchemeColor.
 /// </summary>
 public SchemeColor? SchemeColor { get => _SchemeColor; set => UpdateField(ref _SchemeColor, value, nameof(SchemeColor)); }
 private SchemeColor? _SchemeColor;
}