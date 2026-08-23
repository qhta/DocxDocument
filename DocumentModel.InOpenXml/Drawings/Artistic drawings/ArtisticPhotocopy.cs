namespace DocumentModel.Drawings;

/// <summary>
/// Represents an artistic photocopy effect, which simulates a photocopied appearance with adjustable transparency and detail.
/// </summary>
[OpenXmlType(typeof(DXO10D.ArtisticPhotocopy))]
[DataContract]
[XmlRoot("ArtisticPhotocopy", Namespace = "DocumentModel.Drawings")]
public partial class ArtisticPhotocopy: ModelElement<DXO10D.ArtisticPhotocopy>
{
  /// <summary>
  /// Transparency level of the photocopy effect.
  /// </summary>
  public Int32? Transparency
  {
    get => _Transparency;
    set => UpdateField(ref _Transparency, value, nameof(Transparency));
  }

  private Int32? _Transparency;

  /// <summary>
  /// Detail level of the photocopy effect, influencing the sharpness and clarity of the simulated photocopy.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10D.ArtisticPhotocopy.Detail))]
  public Int32? Detail
  {
    get => _Detail ??= GetProperty<Int32?>(GetUpdatableElement()?.Detail);
    set => UpdateField(ref _Detail, value, nameof(Detail));
  }

  private Int32? _Detail;
}