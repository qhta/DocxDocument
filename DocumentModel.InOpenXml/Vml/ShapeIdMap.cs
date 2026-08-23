namespace DocumentModel.Vml;

/// <summary>
///   Shape ID Map.
/// </summary>
[OpenXmlType(typeof(DXVO.ShapeIdMap))]
[DataContract]
[XmlRoot("ShapeIdMap", Namespace = "DocumentModel.Vml")]
public partial class ShapeIdMap: ModelElement<DXVO.ShapeIdMap>
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.ShapeIdMap.Extension))]
  public ExtensionHandlingBehavior? Extension
  {
    get => _Extension ??= GetProperty<ExtensionHandlingBehavior?>(GetUpdatableElement()?.Extension);
    set => UpdateField(ref _Extension, value, nameof(Extension));
  }

  private ExtensionHandlingBehavior? _Extension;

  /// <summary>
  ///   Shape IDs
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.ShapeIdMap.Data))]
  public string? Data
  {
    get => _Data ??= GetProperty<string?>(GetUpdatableElement()?.Data);
    set => UpdateField(ref _Data, value, nameof(Data));
  }

  private string? _Data;
}