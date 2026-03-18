namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the PivotSource Class.
/// </summary>
[OpenXmlType(typeof(DXDC.PivotSource))]
public partial class PivotSource: ModelElement<DXDC.PivotSource>
{
  /// <summary>
  ///   Pivot Name.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.PivotSource.PivotTableName))]
  public string? PivotTableName
  {
    get => _PivotTableName;
    set => UpdateField(ref _PivotTableName, value, nameof(PivotTableName));
  }

  private string? _PivotTableName;

  /// <summary>
  ///   Format ID.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.PivotSource.FormatId))]
  public UInt32? FormatId { get => _FormatId; set => UpdateField(ref _FormatId, value, nameof(FormatId)); }

  private UInt32? _FormatId;

  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.PivotSource.ExtensionList))]
  public ExtensionList? ExtensionList
  {
    get => _ExtensionList;
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }

  private ExtensionList? _ExtensionList;
}