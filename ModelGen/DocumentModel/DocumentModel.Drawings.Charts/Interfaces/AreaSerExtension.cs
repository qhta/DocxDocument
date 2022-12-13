namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the AreaSerExtension Class.
/// </summary>
public interface AreaSerExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public DocumentModel.Drawings13.Charts.FilteredSeriesTitle? FilteredSeriesTitle { get ; set; }
  
  public DocumentModel.Drawings13.Charts.FilteredCategoryTitle? FilteredCategoryTitle { get ; set; }
  
  public DocumentModel.Drawings13.Charts.DataLabelsRange? DataLabelsRange { get ; set; }
  
  public DocumentModel.Drawings13.Charts.CategoryFilterExceptions? CategoryFilterExceptions { get ; set; }
  
}
