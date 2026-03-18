namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents the surface type for a chart, including thickness, shape properties, picture options, and extensibility.
/// </summary>
[OpenXmlType(typeof(DXDC.SurfaceType))]
public partial class SurfaceType: ModelElement<DXDC.SurfaceType>
{
  /// <summary>
  ///   Thickness of the surface.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.Thickness))]
  public Byte? Thickness { get => _Thickness; set => UpdateField(ref _Thickness, value, nameof(Thickness)); }

  private Byte? _Thickness;

  /// <summary>
  ///   Shape properties for the surface.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ShapeProperties))]
  public ShapeProperties? ShapeProperties
  {
    get => _ShapeProperties;
    set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties));
  }

  private ShapeProperties? _ShapeProperties;

  /// <summary>
  ///   Picture options for the surface.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.PictureOptions))]
  public PictureOptions? PictureOptions
  {
    get => _PictureOptions;
    set => UpdateField(ref _PictureOptions, value, nameof(PictureOptions));
  }

  private PictureOptions? _PictureOptions;

  /// <summary>
  ///   Extension list for additional surface properties.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ExtensionList))]
  public ExtensionList? ExtensionList
  {
    get => _ExtensionList;
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }

  private ExtensionList? _ExtensionList;
}