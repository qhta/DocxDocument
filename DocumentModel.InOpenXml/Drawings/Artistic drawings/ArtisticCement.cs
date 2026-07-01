namespace DocumentModel.Drawings;
/// <summary>
/// Represents an artistic cement effect, which simulates a cement texture with adjustable transparency and crack spacing.
/// </summary>
[OpenXmlType(typeof(DXO10D.ArtisticCement))]
[DataContract]
[XmlRoot("ArtisticCement", Namespace = "DocumentModel.Drawings")]
public partial class ArtisticCement : ModelElement<DXO10D.ArtisticCement>
{
 /// <summary>
 /// Transparency level of the cement effect.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ArtisticCement.Transparancy))]
 public Int32? Transparency { get => _Transparency; set => UpdateField(ref _Transparency, value, nameof(Transparency)); }
 private Int32? _Transparency;

 /// <summary>
 /// Spacing between cracks in the cement effect.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ArtisticCement.CrackSpacing))]
 public Int32? CrackSpacing { get => _CrackSpacing; set => UpdateField(ref _CrackSpacing, value, nameof(CrackSpacing)); }
 private Int32? _CrackSpacing;
}