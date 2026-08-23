namespace DocumentModel.Drawings;

/// <summary>
///   Represents default formatting properties for objects in a theme, including shape, line, and text defaults.
/// </summary>
[OpenXmlType(typeof(DXD.ObjectDefaults))]
[DataContract]
[XmlRoot("ObjectDefaults", Namespace = "DocumentModel.Drawings")]
public partial class ObjectDefaults: ModelElement<DXD.ObjectDefaults>, IExtendableElement
{
  /// <summary>
  ///   Default formatting properties for shapes.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ObjectDefaults.ShapeDefault))]
  public ShapeDefault? ShapeDefault
  {
    get => _ShapeDefault ??= GetProperty<ShapeDefault?>(GetUpdatableElement()?.ShapeDefault);
    set => UpdateField(ref _ShapeDefault, value, nameof(ShapeDefault));
  }

  private ShapeDefault? _ShapeDefault;

  /// <summary>
  ///   Default formatting properties for lines.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ObjectDefaults.LineDefault))]
  public LineDefault? LineDefault
  {
    get => _LineDefault ??= GetProperty<LineDefault?>(GetUpdatableElement()?.LineDefault);
    set => UpdateField(ref _LineDefault, value, nameof(LineDefault));
  }

  private LineDefault? _LineDefault;

  /// <summary>
  ///   Default formatting properties for text.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ObjectDefaults.TextDefault))]
  public TextDefault? TextDefault
  {
    get => _TextDefault ??= GetProperty<TextDefault?>(GetUpdatableElement()?.TextDefault);
    set => UpdateField(ref _TextDefault, value, nameof(TextDefault));
  }

  private TextDefault? _TextDefault;

  /// <summary>
  /// List of extensions for future extensions of the element type.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ObjectDefaults.ExtensionList))]
  public ExtensionList? ExtensionList
  {
    get => _ExtensionList ??= GetProperty<ExtensionList?>(GetUpdatableElement()?.ExtensionList);
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }

  private ExtensionList? _ExtensionList;
}