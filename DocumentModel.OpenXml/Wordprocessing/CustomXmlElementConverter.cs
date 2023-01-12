namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines CustomXmlElement - the base class for the customXml elements.
/// </summary>
public static class CustomXmlElementConverter
{
  /// <summary>
  /// Gets or sets the custom XML Markup Namespace.
  /// </summary>
  public static String? GetUri(DocumentFormat.OpenXml.Wordprocessing.CustomXmlElement? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  public static void SetUri(DocumentFormat.OpenXml.Wordprocessing.CustomXmlElement? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }
  
  /// <summary>
  /// Gets or sets the element name.
  /// </summary>
  public static String? GetElement(DocumentFormat.OpenXml.Wordprocessing.CustomXmlElement? openXmlElement)
  {
    return openXmlElement?.Element?.Value;
  }
  
  public static void SetElement(DocumentFormat.OpenXml.Wordprocessing.CustomXmlElement? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Element = new StringValue { Value = value };
      else
        openXmlElement.Element = null;
  }
  
  /// <summary>
  /// Gets or sets the CustomXmlProperties which represents the element tag in schema: w:customXmlPr.
  /// </summary>
  public static DocumentModel.Wordprocessing.CustomXmlProperties? GetCustomXmlProperties(DocumentFormat.OpenXml.Wordprocessing.CustomXmlElement? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.CustomXmlPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlProperties(DocumentFormat.OpenXml.Wordprocessing.CustomXmlElement? openXmlElement, DocumentModel.Wordprocessing.CustomXmlProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.CustomXmlPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.CustomXmlElement? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.CustomXmlElement? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.CustomXmlElement();
      value.Uri = GetUri(openXmlElement);
      value.Element = GetElement(openXmlElement);
      value.CustomXmlProperties = GetCustomXmlProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.CustomXmlElement? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.CustomXmlElement, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetElement(openXmlElement, value?.Element);
      SetCustomXmlProperties(openXmlElement, value?.CustomXmlProperties);
      return openXmlElement;
    }
    return default;
  }
}
