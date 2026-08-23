namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the PivotSource Class.
/// </summary>
[OpenXmlType(typeof(DXDC.PivotSource))]
[DataContract]
[XmlRoot("PivotSource", Namespace = "DocumentModel.Drawings.Charts")]
public partial class PivotSource: ModelElement<DXDC.PivotSource>
{
  /// <summary>
  ///   Pivot Name.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.PivotSource.PivotTableName))]
  public string? PivotTableName
  {
    get => _PivotTableName ??= GetProperty<string?>(GetUpdatableElement()?.PivotTableName);
    set => UpdateField(ref _PivotTableName, value, nameof(PivotTableName));
  }

  private string? _PivotTableName;

  /// <summary>
  ///   Format ID.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.PivotSource.FormatId))]
  public UInt32? FormatId
  {
    get => _FormatId ??= GetProperty<UInt32?>(GetUpdatableElement()?.FormatId);
    set => UpdateField(ref _FormatId, value, nameof(FormatId));
  }

  private UInt32? _FormatId;

  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.PivotSource.ExtensionList))]
  public IExtensionList? ExtensionList
  {
    get => _ExtensionList ??= GetProperty<IExtensionList?>(GetUpdatableElement()?.ExtensionList);
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }

  private IExtensionList? _ExtensionList;
}