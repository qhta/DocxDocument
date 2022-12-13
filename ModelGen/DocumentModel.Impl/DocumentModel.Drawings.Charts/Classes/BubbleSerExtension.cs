namespace DocumentModel.Drawings.Charts;

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
    get => (System.String?)OpenXmlElement?.Uri?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Uri = (System.String?)value;
    }
  }
  
  public DocumentModel.Drawings.Charts.InvertSolidFillFormat? InvertSolidFillFormat
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
