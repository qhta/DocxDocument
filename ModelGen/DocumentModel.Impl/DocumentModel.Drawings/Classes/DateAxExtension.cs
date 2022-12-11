namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DateAxExtension Class.
/// </summary>
public class DateAxExtensionImpl: ModelElementImpl, DateAxExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.DateAxExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.DateAxExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DateAxExtensionImpl(): base() {}
  
  public DateAxExtensionImpl(DocumentFormat.OpenXml.Drawing.Charts.DateAxExtension openXmlElement): base(openXmlElement)
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
  
  public NumberingFormat? NumberingFormat
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
