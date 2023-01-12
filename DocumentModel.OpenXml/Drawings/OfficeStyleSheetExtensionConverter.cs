namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the OfficeStyleSheetExtension Class.
/// </summary>
public static class OfficeStyleSheetExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  public static String? GetUri(DocumentFormat.OpenXml.Drawing.OfficeStyleSheetExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  public static void SetUri(DocumentFormat.OpenXml.Drawing.OfficeStyleSheetExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }
  
  public static DocumentModel.ThemeFamily? GetThemeFamily(DocumentFormat.OpenXml.Drawing.OfficeStyleSheetExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Theme.ThemeFamily>();
    if (itemElement != null)
      return DocumentModel.OpenXml.ThemeFamilyConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetThemeFamily(DocumentFormat.OpenXml.Drawing.OfficeStyleSheetExtension? openXmlElement, DocumentModel.ThemeFamily? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Theme.ThemeFamily>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.ThemeFamilyConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Theme.ThemeFamily>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.OfficeStyleSheetExtension? CreateModelElement(DocumentFormat.OpenXml.Drawing.OfficeStyleSheetExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.OfficeStyleSheetExtension();
      value.Uri = GetUri(openXmlElement);
      value.ThemeFamily = GetThemeFamily(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.OfficeStyleSheetExtension? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.OfficeStyleSheetExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      return openXmlElement;
    }
    return default;
  }
}
