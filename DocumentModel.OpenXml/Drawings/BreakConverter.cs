namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Text Line Break.
/// </summary>
public static class BreakConverter
{
  /// <summary>
  /// Text Run Properties.
  /// </summary>
  public static DocumentModel.Drawings.RunProperties? GetRunProperties(DocumentFormat.OpenXml.Drawing.Break? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.RunProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.RunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRunProperties(DocumentFormat.OpenXml.Drawing.Break? openXmlElement, DocumentModel.Drawings.RunProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.RunProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.RunPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.RunProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Break? CreateModelElement(DocumentFormat.OpenXml.Drawing.Break? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Break();
      value.RunProperties = GetRunProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Break? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Break, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRunProperties(openXmlElement, value?.RunProperties);
      return openXmlElement;
    }
    return default;
  }
}
