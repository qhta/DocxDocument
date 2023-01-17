namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ThemeElements Class.
/// </summary>
public static class ThemeElementsConverter
{
  /// <summary>
  /// ColorScheme.
  /// </summary>
  private static DocumentModel.Drawings.ColorScheme? GetColorScheme(DocumentFormat.OpenXml.Drawing.ThemeElements openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorScheme>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ColorSchemeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetColorScheme(DocumentFormat.OpenXml.Drawing.ThemeElements openXmlElement, DocumentModel.Drawings.ColorScheme? value)
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
  
  /// <summary>
  /// Font Scheme.
  /// </summary>
  private static DocumentModel.Drawings.FontScheme? GetFontScheme(DocumentFormat.OpenXml.Drawing.ThemeElements openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.FontScheme>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.FontSchemeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFontScheme(DocumentFormat.OpenXml.Drawing.ThemeElements openXmlElement, DocumentModel.Drawings.FontScheme? value)
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
  
  /// <summary>
  /// Format Scheme.
  /// </summary>
  private static DocumentModel.Drawings.FormatScheme? GetFormatScheme(DocumentFormat.OpenXml.Drawing.ThemeElements openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.FormatScheme>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.FormatSchemeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFormatScheme(DocumentFormat.OpenXml.Drawing.ThemeElements openXmlElement, DocumentModel.Drawings.FormatScheme? value)
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
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DocumentModel.Drawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.ThemeElements openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DocumentFormat.OpenXml.Drawing.ThemeElements openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ThemeElements? CreateModelElement(DocumentFormat.OpenXml.Drawing.ThemeElements? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ThemeElements();
      value.ColorScheme = GetColorScheme(openXmlElement);
      value.FontScheme = GetFontScheme(openXmlElement);
      value.FormatScheme = GetFormatScheme(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ThemeElements? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ThemeElements, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetColorScheme(openXmlElement, value?.ColorScheme);
      SetFontScheme(openXmlElement, value?.FontScheme);
      SetFormatScheme(openXmlElement, value?.FormatScheme);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
