namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the PivotSource Class.
/// </summary>
public partial class PivotSource3
{
  /// <summary>
  /// Pivot Name.
  /// </summary>
  public String? PivotTableName { get; set; }
  
  /// <summary>
  /// Format ID.
  /// </summary>
  public UInt32? FormatId { get; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList { get; set; }
  
}
