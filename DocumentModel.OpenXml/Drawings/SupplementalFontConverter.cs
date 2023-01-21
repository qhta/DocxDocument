namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Font.
/// </summary>
public static class SupplementalFontConverter
{
  /// <summary>
  /// Script
  /// </summary>
  private static String? GetScript(DXDraw.SupplementalFont openXmlElement)
  {
    return openXmlElement?.Script?.Value;
  }
  
  private static void SetScript(DXDraw.SupplementalFont openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Script = new StringValue { Value = value };
    else
      openXmlElement.Script = null;
  }
  
  /// <summary>
  /// Typeface
  /// </summary>
  private static String? GetTypeface(DXDraw.SupplementalFont openXmlElement)
  {
    return openXmlElement?.Typeface?.Value;
  }
  
  private static void SetTypeface(DXDraw.SupplementalFont openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Typeface = new StringValue { Value = value };
    else
      openXmlElement.Typeface = null;
  }
  
  public static DMDraws.SupplementalFont? CreateModelElement(DXDraw.SupplementalFont? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.SupplementalFont();
      value.Script = GetScript(openXmlElement);
      value.Typeface = GetTypeface(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.SupplementalFont? value)
    where OpenXmlElementType: DXDraw.SupplementalFont, new()
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
