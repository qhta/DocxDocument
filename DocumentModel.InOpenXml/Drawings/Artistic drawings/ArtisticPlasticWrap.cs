namespace DocumentModel.Drawings;
/// <summary>
/// Represents an artistic plastic wrap effect, which simulates a plastic-wrapped appearance with adjustable transparency and smoothness.
/// </summary>
[OpenXmlType(typeof(DXO10D.ArtisticPlasticWrap))]
[DataContract]
[XmlRoot("ArtisticPlasticWrap", Namespace = "DocumentModel.Drawings")]
public partial class ArtisticPlasticWrap : ModelElement<DXO10D.ArtisticPlasticWrap>
{
 /// <summary>
 /// Transparency level of the plastic wrap effect.
 /// </summary>
 public Int32? Transparency { get => _Transparency; set => UpdateField(ref _Transparency, value, nameof(Transparency)); }
 private Int32? _Transparency;

 /// <summary>
 /// Smoothness of the plastic wrap effect, influencing the softness and clarity of the simulated plastic texture.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ArtisticPlasticWrap.Smoothness))]
 public Int32? Smoothness { get => _Smoothness; set => UpdateField(ref _Smoothness, value, nameof(Smoothness)); }
 private Int32? _Smoothness;
}