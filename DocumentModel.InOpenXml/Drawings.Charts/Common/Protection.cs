namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the Protection Class.
/// </summary>
[OpenXmlType(typeof(DXDC.Protection))]
[DataContract]
[XmlRoot("Protection", Namespace = "DocumentModel.Drawings.Charts")]
public partial class Protection: ModelElement<DXDC.Protection>
{
  /// <summary>
  ///   Chart Object.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.Protection.ChartObject))]
  public bool? ChartObject
  {
    get => _ChartObject ??= GetProperty<bool?>(GetUpdatableElement()?.ChartObject);
    set => UpdateField(ref _ChartObject, value, nameof(ChartObject));
  }

  private bool? _ChartObject;

  /// <summary>
  ///   Data Cannot Be Changed.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.Protection.Data))]
  public bool? Data
  {
    get => _Data ??= GetProperty<bool?>(GetUpdatableElement()?.Data);
    set => UpdateField(ref _Data, value, nameof(Data));
  }

  private bool? _Data;

  /// <summary>
  ///   Formatting.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.Protection.Formatting))]
  public bool? Formatting
  {
    get => _Formatting ??= GetProperty<bool?>(GetUpdatableElement()?.Formatting);
    set => UpdateField(ref _Formatting, value, nameof(Formatting));
  }

  private bool? _Formatting;

  /// <summary>
  ///   Selection.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.Protection.Selection))]
  public bool? Selection
  {
    get => _Selection ??= GetProperty<bool?>(GetUpdatableElement()?.Selection);
    set => UpdateField(ref _Selection, value, nameof(Selection));
  }

  private bool? _Selection;
}