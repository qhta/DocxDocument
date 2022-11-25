namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Consolidation Class.
/// </summary>
public interface IConsolidation // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Auto Page
  /// </summary>
  public System.Boolean? AutoPage { get ; set; }
  
  /// <summary>
  /// Page Item Values.
  /// </summary>
  public DocumentModel.Spreadsheet.IPages? Pages { get ; set; }
  
  /// <summary>
  /// Range Sets.
  /// </summary>
  public DocumentModel.Spreadsheet.IRangeSets? RangeSets { get ; set; }
  
}
