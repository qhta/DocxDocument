namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PivotSource Class.
/// </summary>
public interface PivotSource2
{
  /// <summary>
  /// Pivot Name.
  /// </summary>
  public String? PivotTableName { get ; set; }
  
  /// <summary>
  /// Format ID.
  /// </summary>
  public UInt32? FormatId { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public ExtensionList3? ExtensionList { get ; set; }
  
}
