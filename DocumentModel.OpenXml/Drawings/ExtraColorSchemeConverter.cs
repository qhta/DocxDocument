namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Extra Color Scheme.
/// </summary>
public static class ExtraColorSchemeConverter
{
  /// <summary>
  /// ColorScheme.
  /// </summary>
  public static DocumentModel.Drawings.ColorScheme? GetColorScheme(DocumentFormat.OpenXml.Drawing.ExtraColorScheme? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorScheme>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ColorSchemeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetColorScheme(DocumentFormat.OpenXml.Drawing.ExtraColorScheme? openXmlElement, DocumentModel.Drawings.ColorScheme? value)
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
  /// ColorMap.
  /// </summary>
  public static DocumentModel.Drawings.ColorMap? GetColorMap(DocumentFormat.OpenXml.Drawing.ExtraColorScheme? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorMap>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ColorMapConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetColorMap(DocumentFormat.OpenXml.Drawing.ExtraColorScheme? openXmlElement, DocumentModel.Drawings.ColorMap? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorMap>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ColorMapConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ColorMap>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ExtraColorScheme? CreateModelElement(DocumentFormat.OpenXml.Drawing.ExtraColorScheme? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ExtraColorScheme();
      value.ColorScheme = GetColorScheme(openXmlElement);
      value.ColorMap = GetColorMap(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ExtraColorScheme? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ExtraColorScheme, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetColorScheme(openXmlElement, value?.ColorScheme);
      SetColorMap(openXmlElement, value?.ColorMap);
      return openXmlElement;
    }
    return default;
  }
}
