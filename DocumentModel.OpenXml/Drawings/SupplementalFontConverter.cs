namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Font.
/// </summary>
public static class SupplementalFontConverter
{
  /// <summary>
  /// Script
  /// </summary>
  private static String? GetScript(DocumentFormat.OpenXml.Drawing.SupplementalFont openXmlElement)
  {
    return openXmlElement?.Script?.Value;
  }
  
  private static void SetScript(DocumentFormat.OpenXml.Drawing.SupplementalFont openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Script = new StringValue { Value = value };
    else
      openXmlElement.Script = null;
  }
  
  /// <summary>
  /// Typeface
  /// </summary>
  private static String? GetTypeface(DocumentFormat.OpenXml.Drawing.SupplementalFont openXmlElement)
  {
    return openXmlElement?.Typeface?.Value;
  }
  
  private static void SetTypeface(DocumentFormat.OpenXml.Drawing.SupplementalFont openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Typeface = new StringValue { Value = value };
    else
      openXmlElement.Typeface = null;
  }
  
  public static DocumentModel.Drawings.SupplementalFont? CreateModelElement(DocumentFormat.OpenXml.Drawing.SupplementalFont? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.SupplementalFont();
      value.Script = GetScript(openXmlElement);
      value.Typeface = GetTypeface(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.SupplementalFont? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.SupplementalFont, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetScript(openXmlElement, value?.Script);
      SetTypeface(openXmlElement, value?.Typeface);
      return openXmlElement;
    }
    return default;
  }
}
