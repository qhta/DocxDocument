namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the SurfaceSerExtension Class.
/// </summary>
public interface SurfaceSerExtension: Extension
{
  public FilteredSeriesTitle? FilteredSeriesTitle { get; set; }
  public FilteredCategoryTitle? FilteredCategoryTitle { get; set; }
  public CategoryFilterExceptions? CategoryFilterExceptions { get; set; }
}