namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents the surface type for a chart, including thickness, shape properties, picture options, and extensibility.
/// </summary>
[OpenXmlType(typeof(DXDC.SurfaceType))]
[DataContract]
[XmlRoot("SurfaceType", Namespace = "DocumentModel.Drawings.Charts")]
public partial class SurfaceType: ModelElement<DXDC.SurfaceType>
{
  /// <summary>
  ///   Thickness of the surface.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.Thickness))]
  public Byte? Thickness
  {
    get => _Thickness ??= GetElement<Byte, DXDC.Thickness>(GetUpdatableElement());
    set => UpdateField(ref _Thickness, value, nameof(Thickness));
  }

  private Byte? _Thickness;

  /// <summary>
  ///   Shape properties for the surface.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ShapeProperties))]
  public ShapeProperties? ShapeProperties
  {
    get => _ShapeProperties ??= GetElement<ShapeProperties, DXDC.ShapeProperties>(GetUpdatableElement());
    set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties));
  }

  private ShapeProperties? _ShapeProperties;

  /// <summary>
  ///   Picture options for the surface.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.PictureOptions))]
  public PictureOptions? PictureOptions
  {
    get => _PictureOptions ??= GetElement<PictureOptions, DXDC.PictureOptions>(GetUpdatableElement());
    set => UpdateField(ref _PictureOptions, value, nameof(PictureOptions));
  }

  private PictureOptions? _PictureOptions;

  /// <summary>
  ///   Extension list for additional surface properties.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ExtensionList))]
  public IExtensionList? ExtensionList
  {
    get => _ExtensionList ??= GetElement<IExtensionList, DXDC.ExtensionList>(GetUpdatableElement());
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }

  private IExtensionList? _ExtensionList;
}