namespace DocumentModel.Drawings;

/// <summary>
/// Defines the SurfaceSerExtension Class.
/// </summary>
public interface SurfaceSerExtension
{
  public FilteredSeriesTitle? FilteredSeriesTitle { get ; set; }
  
  public FilteredCategoryTitle? FilteredCategoryTitle { get ; set; }
  
  public CategoryFilterExceptions? CategoryFilterExceptions { get ; set; }
  
}
