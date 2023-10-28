namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the SurfaceSerExtension Class.
/// </summary>
public partial class SurfaceSerExtension
{
  
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }
  
  public DMDC13.FilteredSeriesTitle? FilteredSeriesTitle { get; set; }
  
  public DMDC13.FilteredCategoryTitle? FilteredCategoryTitle { get; set; }
  
  public DMDC13.CategoryFilterExceptions? CategoryFilterExceptions { get; set; }
  
}
