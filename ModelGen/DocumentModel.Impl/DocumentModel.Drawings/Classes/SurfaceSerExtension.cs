namespace DocumentModel.Drawings;

/// <summary>
/// Defines the SurfaceSerExtension Class.
/// </summary>
public class SurfaceSerExtensionImpl: ModelElementImpl, SurfaceSerExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get;
    set;
  }
  
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
