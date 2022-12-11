namespace DocumentModel.Drawings;

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
    get => (String?)OpenXmlElement?.Uri?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Uri = (System.String?)value;
    }
  }
  
  public FilteredSeriesTitle? FilteredSeriesTitle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public FilteredCategoryTitle? FilteredCategoryTitle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DataLabelsRange? DataLabelsRange
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public CategoryFilterExceptions? CategoryFilterExceptions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
