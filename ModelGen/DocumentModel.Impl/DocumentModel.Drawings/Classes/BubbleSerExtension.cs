namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BubbleSerExtension Class.
/// </summary>
public class BubbleSerExtensionImpl: ModelElementImpl, BubbleSerExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BubbleSerExtensionImpl(): base() {}
  
  public BubbleSerExtensionImpl(DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtension openXmlElement): base(openXmlElement)
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
  
  public InvertSolidFillFormat? InvertSolidFillFormat
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
