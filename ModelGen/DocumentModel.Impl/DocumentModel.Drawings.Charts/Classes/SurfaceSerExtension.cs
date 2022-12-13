namespace DocumentModel.Drawings.Charts;

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
  
  public SurfaceSerExtensionImpl(): base() {}
  
  public SurfaceSerExtensionImpl(DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtension openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get => (System.String?)OpenXmlElement?.Uri?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Uri = (System.String?)value;
    }
  }
  
  public DocumentModel.Drawings13.Charts.FilteredSeriesTitle? FilteredSeriesTitle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings13.Charts.FilteredCategoryTitle? FilteredCategoryTitle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings13.Charts.CategoryFilterExceptions? CategoryFilterExceptions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
