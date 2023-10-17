namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the PivotSource Class.
/// </summary>
public partial class PivotSource
{
  
  /// <summary>
  ///   Pivot Name.
  /// </summary>
  public DocumentModel.Drawings.Charts.PivotTableName? PivotTableName { get; set; }
  
  
  /// <summary>
  ///   Format ID.
  /// </summary>
  public DocumentModel.Drawings.Charts.FormatId? FormatId { get; set; }
  
  
  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList { get; set; }
  
}
