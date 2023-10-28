namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the PivotSource Class.
/// </summary>
public partial class PivotSource
{
  
  /// <summary>
  ///   Pivot Name.
  /// </summary>
  public DMDC.PivotTableName? PivotTableName { get; set; }
  
  
  /// <summary>
  ///   Format ID.
  /// </summary>
  public DMDC.FormatId? FormatId { get; set; }
  
  
  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public DMDC.ExtensionList? ExtensionList { get; set; }
  
}
