namespace DocumentModel.Drawings;
/// <summary>
///   Represents a tint effect, allowing adjustment of hue and amount for color modification.
/// </summary>
[OpenXmlType(typeof(DXD.TintEffect))]
[XmlRoot("TintEffect", Namespace = "DocumentModel.Drawings")]
public partial class TintEffect : ModelElement<DXD.TintEffect>
{
 /// <summary>
 ///   Hue adjustment value for the tint effect.
 /// </summary>
 public Int32? Hue { get => _Hue; set => UpdateField(ref _Hue, value, nameof(Hue)); }
 private Int32? _Hue;

 /// <summary>
 ///   Amount of tint to apply.
 /// </summary>
 public Int32? Amount { get => _Amount; set => UpdateField(ref _Amount, value, nameof(Amount)); }
 private Int32? _Amount;
}