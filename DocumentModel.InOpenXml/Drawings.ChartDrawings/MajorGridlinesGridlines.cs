namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Defines the MajorGridlinesGridlines Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.MajorGridlinesGridlines))]
public class MajorGridlinesGridlines: ModelElement<DXO16DCD.MajorGridlinesGridlines>
{
  /// <summary>
  /// Specifies the shape properties.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.MajorGridlinesGridlines.ShapeProperties))]
  public ShapeProperties? ShapeProperties
  {
    get => _ShapeProperties;
    set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties));
  }
  private ShapeProperties? _ShapeProperties;
  /// <summary>
  /// Specifies the extension list.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.MajorGridlinesGridlines.ExtensionList))]
  public ExtensionList? ExtensionList
  {
    get => _ExtensionList;
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }
  private ExtensionList? _ExtensionList;
}