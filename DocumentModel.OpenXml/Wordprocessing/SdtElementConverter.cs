namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines SdtElement - the base class for the sdt elements.
/// </summary>
public static class SdtElementConverter
{
  /// <summary>
  /// Gets or sets the SdtProperties.
  /// </summary>
  public static DocumentModel.Wordprocessing.SdtProperties? GetSdtProperties(DocumentFormat.OpenXml.Wordprocessing.SdtElement? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.SdtPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSdtProperties(DocumentFormat.OpenXml.Wordprocessing.SdtElement? openXmlElement, DocumentModel.Wordprocessing.SdtProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.SdtPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SdtProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Gets or sets the SdtEndCharProperties.
  /// </summary>
  public static DocumentModel.Wordprocessing.SdtEndCharProperties? GetSdtEndCharProperties(DocumentFormat.OpenXml.Wordprocessing.SdtElement? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtEndCharProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.SdtEndCharPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSdtEndCharProperties(DocumentFormat.OpenXml.Wordprocessing.SdtElement? openXmlElement, DocumentModel.Wordprocessing.SdtEndCharProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtEndCharProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.SdtEndCharPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SdtEndCharProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.SdtElement? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.SdtElement? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.SdtElement();
      value.SdtProperties = GetSdtProperties(openXmlElement);
      value.SdtEndCharProperties = GetSdtEndCharProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.SdtElement? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.SdtElement, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSdtProperties(openXmlElement, value?.SdtProperties);
      SetSdtEndCharProperties(openXmlElement, value?.SdtEndCharProperties);
      return openXmlElement;
    }
    return default;
  }
}
