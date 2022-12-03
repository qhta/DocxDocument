namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Consolidation Class.
/// </summary>
public interface Consolidation // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Auto Page
  /// </summary>
  public Boolean? AutoPage { get ; set; }
  
  /// <summary>
  /// Page Item Values.
  /// </summary>
  public Pages? Pages { get ; set; }
  
  /// <summary>
  /// Range Sets.
  /// </summary>
  public RangeSets? RangeSets { get ; set; }
  
}
