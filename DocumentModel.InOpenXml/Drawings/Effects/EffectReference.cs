namespace DocumentModel.Drawings;
/// <summary>
/// Represents a reference to various color models and color types used in drawing effects.
/// </summary>
[OpenXmlType(typeof(DXD.EffectReference))]
[DataContract]
[XmlRoot("EffectReference", Namespace = "DocumentModel.Drawings")]
public partial class EffectReference : ModelElement<DXD.EffectReference>
{
 /// <summary>
 /// RGB color model using percentage values.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.EffectReference.RgbColorModelPercentage))]
 public ColorType? Color { get => _Color; set => UpdateField(ref _Color, value, nameof(Color)); }
 private ColorType? _Color;

}