namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Consolidation Class.
/// </summary>
public interface IConsolidation // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Auto Page
  /// </summary>
  public Boolean? AutoPage { get ; set; }
  
  /// <summary>
  /// Page Item Values.
  /// </summary>
  public IPages? Pages { get ; set; }
  
  /// <summary>
  /// Range Sets.
  /// </summary>
  public IRangeSets? RangeSets { get ; set; }
  
}
