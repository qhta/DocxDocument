namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the ScatterSerExtension Class.
/// </summary>
public interface ScatterSerExtension
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
