namespace DocumentModel.Drawings.Charts;

/// <summary>
///   3D side wall formatting.
/// </summary>
[OpenXmlType(typeof(DXDC.SideWall))]
[DataContract]
[XmlRoot("SideWall", Namespace = "DocumentModel.Drawings.Charts")]
public partial class SideWall: ModelElement<DXDC.SideWall>
{
  /// <summary>
  /// The thickness of the side wall.
  /// The value is in percentage of the depth of the chart.
  /// The default value is 100000, which means 100%.
  /// The minimum value is 0, and the maximum value is 300000, which means 300%.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.SideWall.Thickness))]
  public Byte? Thickness
  {
    get => _Thickness ??= GetProperty<Byte?>(GetUpdatableElement()?.Thickness);
    set => UpdateField(ref _Thickness, value, nameof(Thickness));
  }

  private Byte? _Thickness;

  /// <summary>
  /// The shape properties of the side wall.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.SideWall.ShapeProperties))]
  public ShapeProperties? ShapeProperties
  {
    get => _ShapeProperties ??= GetProperty<ShapeProperties?>(GetUpdatableElement()?.ShapeProperties);
    set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties));
  }

  private ShapeProperties? _ShapeProperties;

  /// <summary>
  /// The picture options of the side wall.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.SideWall.PictureOptions))]
  public PictureOptions? PictureOptions
  {
    get => _PictureOptions ??= GetProperty<PictureOptions?>(GetUpdatableElement()?.PictureOptions);
    set => UpdateField(ref _PictureOptions, value, nameof(PictureOptions));
  }

  private PictureOptions? _PictureOptions;

  /// <summary>
  /// The extension list of the side wall.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.SideWall.ExtensionList))]
  public IExtensionList? ExtensionList
  {
    get => _ExtensionList ??= GetProperty<IExtensionList?>(GetUpdatableElement()?.ExtensionList);
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }

  private IExtensionList? _ExtensionList;
}