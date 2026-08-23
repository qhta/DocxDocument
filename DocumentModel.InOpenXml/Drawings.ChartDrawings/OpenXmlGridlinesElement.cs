namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the OpenXmlGridlinesElement Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.OpenXmlGridlinesElement))]
[DataContract]
[XmlRoot("OpenXmlGridlinesElement", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class OpenXmlGridlinesElement: ModelElement<DXO16DCD.OpenXmlGridlinesElement>
{
  /// <summary>
  /// Specifies the shape properties.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.OpenXmlGridlinesElement.ShapeProperties))]
  public ShapeProperties? ShapeProperties
  {
    get => _ShapeProperties ??= GetProperty<ShapeProperties?>(GetUpdatableElement()?.ShapeProperties);
    set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties));
  }

  private ShapeProperties? _ShapeProperties;

  /// <summary>
  /// Specifies the extension list.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.OpenXmlGridlinesElement.ExtensionList))]
  public IExtensionList? ExtensionList
  {
    get => _ExtensionList ??= GetProperty<IExtensionList?>(GetUpdatableElement()?.ExtensionList);
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }

  private IExtensionList? _ExtensionList;
}