namespace DocumentModel.Drawings;

/// <summary>
/// Represents an artistic diffused glow effect, which simulates a soft glowing appearance with adjustable transparency and intensity.
/// </summary>
[OpenXmlType(typeof(DXO10D.ArtisticGlowDiffused))]
[DataContract]
[XmlRoot("ArtisticGlowDiffused", Namespace = "DocumentModel.Drawings")]
public partial class ArtisticGlowDiffused: ModelElement<DXO10D.ArtisticGlowDiffused>
{
  /// <summary>
  /// Transparency level of the diffused glow effect.
  /// </summary>
  public Int32? Transparency
  {
    get => _Transparency;
    set => UpdateField(ref _Transparency, value, nameof(Transparency));
  }

  private Int32? _Transparency;

  /// <summary>
  /// Intensity of the diffused glow effect, influencing the strength of the glow.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10D.ArtisticGlowDiffused.Intensity))]
  public Int32? Intensity
  {
    get => _Intensity ??= GetProperty<Int32?>(GetUpdatableElement()?.Intensity);
    set => UpdateField(ref _Intensity, value, nameof(Intensity));
  }

  private Int32? _Intensity;
}