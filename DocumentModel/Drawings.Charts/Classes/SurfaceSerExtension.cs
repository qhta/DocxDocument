namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the SurfaceSerExtension Class.
/// </summary>
public class SurfaceSerExtension
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public FilteredSeriesTitle? FilteredSeriesTitle { get; set; }

  public FilteredCategoryTitle? FilteredCategoryTitle { get; set; }

  public CategoryFilterExceptions? CategoryFilterExceptions { get; set; }
}