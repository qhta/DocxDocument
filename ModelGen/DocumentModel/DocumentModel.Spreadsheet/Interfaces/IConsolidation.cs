namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Consolidation Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPages))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IRangeSets))]
public interface IConsolidation // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Auto Page
  /// </summary>
  public bool? AutoPage { get ; set; }
  
  /// <summary>
  /// Page Item Values.
  /// </summary>
  public DocumentModel.Spreadsheet.IPages? Pages { get ; set; }
  
  /// <summary>
  /// Range Sets.
  /// </summary>
  public IRangeSets? RangeSets { get ; set; }
  
}
