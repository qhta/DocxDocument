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
    get => (System.String?)OpenXmlElement?.Uri?.Value;
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
    get => (System.String?)OpenXmlElement?.Element?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Element = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Gets or sets the CustomXmlProperties which represents the element tag in schema: w:customXmlPr.
  /// </summary>
  public virtual DocumentModel.Wordprocessing.CustomXmlProperties? CustomXmlProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlProperties>();
        if (item != null)
          return new DocumentModel.Wordprocessing.CustomXmlPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.CustomXmlPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
