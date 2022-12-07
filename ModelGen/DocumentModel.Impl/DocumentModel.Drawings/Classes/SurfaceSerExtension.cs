namespace DocumentModel.Drawings;

/// <summary>
/// Defines the SurfaceSerExtension Class.
/// </summary>
public class SurfaceSerExtensionImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtension>, SurfaceSerExtension
{
  public FilteredSeriesTitle? FilteredSeriesTitle
  {
    get;
    set;
  }
  
  public FilteredCategoryTitle? FilteredCategoryTitle
  {
    get;
    set;
  }
  
  public CategoryFilterExceptions? CategoryFilterExceptions
  {
    get;
    set;
  }
  
}
