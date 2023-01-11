namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Theme Override.
/// </summary>
public static class ThemeOverrideConverter
{
  /// <summary>
  /// Color Scheme.
  /// </summary>
  public static DocumentModel.Drawings.ColorScheme? GetColorScheme(DocumentFormat.OpenXml.Drawing.ThemeOverride? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorScheme>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ColorSchemeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetColorScheme(DocumentFormat.OpenXml.Drawing.ThemeOverride? openXmlElement, DocumentModel.Drawings.ColorScheme? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorScheme>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ColorSchemeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ColorScheme>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// FontScheme.
  /// </summary>
  public static DocumentModel.Drawings.FontScheme? GetFontScheme(DocumentFormat.OpenXml.Drawing.ThemeOverride? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.FontScheme>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.FontSchemeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFontScheme(DocumentFormat.OpenXml.Drawing.ThemeOverride? openXmlElement, DocumentModel.Drawings.FontScheme? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.FontScheme>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.FontSchemeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.FontScheme>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// FormatScheme.
  /// </summary>
  public static DocumentModel.Drawings.FormatScheme? GetFormatScheme(DocumentFormat.OpenXml.Drawing.ThemeOverride? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.FormatScheme>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.FormatSchemeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFormatScheme(DocumentFormat.OpenXml.Drawing.ThemeOverride? openXmlElement, DocumentModel.Drawings.FormatScheme? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.FormatScheme>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.FormatSchemeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.FormatScheme>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ThemeOverride? CreateModelElement(DocumentFormat.OpenXml.Drawing.ThemeOverride? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ThemeOverride();
      value.ColorScheme = GetColorScheme(openXmlElement);
      value.FontScheme = GetFontScheme(openXmlElement);
      value.FormatScheme = GetFormatScheme(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ThemeOverride? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ThemeOverride, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
