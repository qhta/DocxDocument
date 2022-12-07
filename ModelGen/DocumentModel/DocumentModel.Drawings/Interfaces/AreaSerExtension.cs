namespace DocumentModel.Drawings;

/// <summary>
/// Defines the AreaSerExtension Class.
/// </summary>
public interface AreaSerExtension
{
  public FilteredSeriesTitle? FilteredSeriesTitle { get ; set; }
  
  public FilteredCategoryTitle? FilteredCategoryTitle { get ; set; }
  
  public DataLabelsRange? DataLabelsRange { get ; set; }
  
  public CategoryFilterExceptions? CategoryFilterExceptions { get ; set; }
  
}
