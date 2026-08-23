namespace DocumentModel.Drawings;

/// <summary>
///   Represents the extent (width and height) for 2D drawings, measured in English Metric Units (EMUs).
/// </summary>
[OpenXmlType(typeof(DXDW.Extent))]
[DataContract]
[XmlRoot("Extent", Namespace = "DocumentModel.Drawings")]
public partial class Extent: ModelElement<DXDW.Extent>
{
  /// <summary>
  ///   Width of the extent in EMUs.
  /// </summary>
  [OpenXmlProperty(nameof(DXDW.Extent.Cx))]
  public EMU? Cx
  {
    get => _Cx ??= GetProperty<EMU?>(GetUpdatableElement()?.Cx);
    set => UpdateField(ref _Cx, value, nameof(Cx));
  }

  private EMU? _Cx;

  /// <summary>
  ///   Height of the extent in EMUs.
  /// </summary>
  [OpenXmlProperty(nameof(DXDW.Extent.Cy))]
  public EMU? Cy
  {
    get => _Cy ??= GetProperty<EMU?>(GetUpdatableElement()?.Cy);
    set => UpdateField(ref _Cy, value, nameof(Cy));
  }

  private EMU? _Cy;
}