namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
///   Defines the SolidColorFillProperties Class.
/// </summary>
[OpenXmlType(typeof(DXO10W.SolidColorFillProperties))]
[XmlRoot("SolidColorFillProperties", Namespace = "DocumentModel.Wordprocessing.Drawings")]
public partial class SolidColorFillProperties : ModelElement<DXO10W.SolidColorFillProperties>
{
 /// <summary>
 ///   RgbColorModelHex.
 /// </summary>
 public RgbColorHex? RgbColor { get => _RgbColor; set => UpdateField(ref _RgbColor, value, nameof(RgbColor)); }

 private RgbColorHex? _RgbColor;
 /// <summary>
 ///   SchemeColor.
 /// </summary>
 public SchemeColor? SchemeColor { get => _SchemeColor; set => UpdateField(ref _SchemeColor, value, nameof(SchemeColor)); }

 private SchemeColor? _SchemeColor;
}