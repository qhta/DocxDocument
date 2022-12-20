namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the LineSerExtension Class.
/// </summary>
public partial interface LineSerExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get; set; }
  
  public DocumentModel.Drawings.Charts.FilteredSeriesTitle? FilteredSeriesTitle { get; set; }
  
  public DocumentModel.Drawings.Charts.FilteredCategoryTitle? FilteredCategoryTitle { get; set; }
  
  public DocumentModel.Drawings.Charts.DataLabelsRange? DataLabelsRange { get; set; }
  
  public DocumentModel.Drawings.Charts.CategoryFilterExceptions? CategoryFilterExceptions { get; set; }
  
}
