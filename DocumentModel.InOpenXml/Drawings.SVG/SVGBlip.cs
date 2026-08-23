namespace DocumentModel.Drawings.SVG;

/// <summary>
///   Defines the SVGBlip Class.
/// </summary>
[OpenXmlType(typeof(DXO19DS.SVGBlip))]
[DataContract]
[XmlRoot("SVGBlip", Namespace = "DocumentModel.Drawings.SVG")]
public partial class SVGBlip: ModelElement<DXO19DS.SVGBlip>
{
  /// <summary>
  ///   Embedded Picture Reference
  /// </summary>
  [OpenXmlProperty(nameof(DXO19DS.SVGBlip.Embed))]
  public string? Embed
  {
    get => _Embed ??= GetProperty<string?>(GetUpdatableElement()?.Embed);
    set => UpdateField(ref _Embed, value, nameof(Embed));
  }

  private string? _Embed;

  /// <summary>
  ///   Linked Picture Reference
  /// </summary>
  [OpenXmlProperty(nameof(DXO19DS.SVGBlip.Link))]
  public string? Link
  {
    get => _Link ??= GetProperty<string?>(GetUpdatableElement()?.Link);
    set => UpdateField(ref _Link, value, nameof(Link));
  }

  private string? _Link;
}