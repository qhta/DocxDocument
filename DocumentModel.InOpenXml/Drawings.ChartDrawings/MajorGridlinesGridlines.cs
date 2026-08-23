namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the MajorGridlinesGridlines Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.MajorGridlinesGridlines))]
[DataContract]
[XmlRoot("MajorGridlinesGridlines", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class MajorGridlinesGridlines: ModelElement<DXO16DCD.MajorGridlinesGridlines>
{
  /// <summary>
  /// Specifies the shape properties.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.MajorGridlinesGridlines.ShapeProperties))]
  public ShapeProperties? ShapeProperties
  {
    get => _ShapeProperties ??= GetProperty<ShapeProperties?>(GetUpdatableElement()?.ShapeProperties);
    set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties));
  }

  private ShapeProperties? _ShapeProperties;

  /// <summary>
  /// Specifies the extension list.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.MajorGridlinesGridlines.ExtensionList))]
  public IExtensionList? ExtensionList
  {
    get => _ExtensionList ??= GetProperty<IExtensionList?>(GetUpdatableElement()?.ExtensionList);
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }

  private IExtensionList? _ExtensionList;
}