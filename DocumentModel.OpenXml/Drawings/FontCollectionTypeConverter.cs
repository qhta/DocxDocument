namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the FontCollectionType Class.
/// </summary>
public static class FontCollectionTypeConverter
{
  /// <summary>
  /// Latin Font.
  /// </summary>
  public static DocumentModel.Drawings.TextFontType? GetLatinFont(DocumentFormat.OpenXml.Drawing.FontCollectionType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.LatinFont>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.TextFontTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLatinFont(DocumentFormat.OpenXml.Drawing.FontCollectionType? openXmlElement, DocumentModel.Drawings.TextFontType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LatinFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.TextFontTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.LatinFont>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// East Asian Font.
  /// </summary>
  public static DocumentModel.Drawings.TextFontType? GetEastAsianFont(DocumentFormat.OpenXml.Drawing.FontCollectionType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.EastAsianFont>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.TextFontTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetEastAsianFont(DocumentFormat.OpenXml.Drawing.FontCollectionType? openXmlElement, DocumentModel.Drawings.TextFontType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EastAsianFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.TextFontTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.EastAsianFont>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Complex Script Font.
  /// </summary>
  public static DocumentModel.Drawings.TextFontType? GetComplexScriptFont(DocumentFormat.OpenXml.Drawing.FontCollectionType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ComplexScriptFont>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.TextFontTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetComplexScriptFont(DocumentFormat.OpenXml.Drawing.FontCollectionType? openXmlElement, DocumentModel.Drawings.TextFontType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ComplexScriptFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.TextFontTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ComplexScriptFont>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.FontCollectionType? CreateModelElement(DocumentFormat.OpenXml.Drawing.FontCollectionType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.FontCollectionType();
      value.LatinFont = GetLatinFont(openXmlElement);
      value.EastAsianFont = GetEastAsianFont(openXmlElement);
      value.ComplexScriptFont = GetComplexScriptFont(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.FontCollectionType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.FontCollectionType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLatinFont(openXmlElement, value?.LatinFont);
      SetEastAsianFont(openXmlElement, value?.EastAsianFont);
      SetComplexScriptFont(openXmlElement, value?.ComplexScriptFont);
      return openXmlElement;
    }
    return default;
  }
}
