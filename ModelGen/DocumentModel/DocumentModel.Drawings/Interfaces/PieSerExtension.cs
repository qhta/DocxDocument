namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PieSerExtension Class.
/// </summary>
public interface PieSerExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public FilteredSeriesTitle? FilteredSeriesTitle { get ; set; }
  
  public FilteredCategoryTitle? FilteredCategoryTitle { get ; set; }
  
  public DataLabelsRange? DataLabelsRange { get ; set; }
  
  public CategoryFilterExceptions? CategoryFilterExceptions { get ; set; }
  
}
