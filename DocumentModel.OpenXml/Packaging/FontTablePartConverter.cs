namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the FontTablePart
/// </summary>
public static class FontTablePartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.FontTablePart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets the FontParts of the FontTablePart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.FontPart>? GetFontParts(DocumentFormat.OpenXml.Packaging.FontTablePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.FontPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.FontPart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.FontPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public static DocumentModel.Wordprocessing.Fonts? GetFonts(DocumentFormat.OpenXml.Packaging.FontTablePart? openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Wordprocessing.Fonts rootElement)
      return DocumentModel.OpenXml.Wordprocessing.FontsConverter.CreateModelElement(rootElement);
    return null;
  }
  
  public static void SetFonts(DocumentFormat.OpenXml.Packaging.FontTablePart? openXmlElement, DocumentModel.Wordprocessing.Fonts? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
         var rootElement = DocumentModel.OpenXml.Wordprocessing.FontsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Fonts>(value);
         if (rootElement != null)
           openXmlElement.Fonts = rootElement;
      }
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.FontTablePart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DocumentModel.Packaging.FontTablePart? CreateModelElement(DocumentFormat.OpenXml.Packaging.FontTablePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.FontTablePart();
      value.ContentType = GetContentType(openXmlElement);
      value.FontParts = GetFontParts(openXmlElement);
      value.Fonts = GetFonts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.FontTablePart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.FontTablePart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetFontParts(openXmlElement, value?.FontParts);
      SetFonts(openXmlElement, value?.Fonts);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}
