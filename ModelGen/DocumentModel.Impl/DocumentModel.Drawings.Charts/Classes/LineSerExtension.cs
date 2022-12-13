namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the LineSerExtension Class.
/// </summary>
public class LineSerExtensionImpl: ModelElementImpl, LineSerExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.LineSerExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.LineSerExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LineSerExtensionImpl(): base() {}
  
  public LineSerExtensionImpl(DocumentFormat.OpenXml.Drawing.Charts.LineSerExtension openXmlElement): base(openXmlElement)
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
  
  public DocumentModel.Drawings13.Charts.DataLabelsRange? DataLabelsRange
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
