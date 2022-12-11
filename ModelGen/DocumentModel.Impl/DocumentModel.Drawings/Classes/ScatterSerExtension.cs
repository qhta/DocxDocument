namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ScatterSerExtension Class.
/// </summary>
public class ScatterSerExtensionImpl: ModelElementImpl, ScatterSerExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ScatterSerExtensionImpl(): base() {}
  
  public ScatterSerExtensionImpl(DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtension openXmlElement): base(openXmlElement)
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
