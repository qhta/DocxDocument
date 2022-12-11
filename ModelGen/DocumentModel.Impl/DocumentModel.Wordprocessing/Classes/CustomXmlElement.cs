namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines CustomXmlElement - the base class for the customXml elements.
/// </summary>
public class CustomXmlElementImpl: ModelElementImpl, CustomXmlElement
{
  public DocumentFormat.OpenXml.Wordprocessing.CustomXmlElement? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.CustomXmlElement?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CustomXmlElementImpl(): base() {}
  
  public CustomXmlElementImpl(DocumentFormat.OpenXml.Wordprocessing.CustomXmlElement openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets or sets the custom XML Markup Namespace.
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
  
  /// <summary>
  /// Gets or sets the element name.
  /// </summary>
  public String? Element
  {
    get => (String?)OpenXmlElement?.Element?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Element = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Gets or sets the CustomXmlProperties which represents the element tag in schema: w:customXmlPr.
  /// </summary>
  public virtual CustomXmlProperties? CustomXmlProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
