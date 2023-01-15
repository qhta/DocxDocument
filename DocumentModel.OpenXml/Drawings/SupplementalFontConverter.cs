using DocumentFormat.OpenXml.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Font.
/// </summary>
public static class SupplementalFontConverter
{
  /// <summary>
  ///   Script
  /// </summary>
  public static String? GetScript(SupplementalFont? openXmlElement)
  {
    return openXmlElement?.Script?.Value;
  }

  public static void SetScript(SupplementalFont? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Script = new StringValue { Value = value };
      else
        openXmlElement.Script = null;
  }

  /// <summary>
  ///   Typeface
  /// </summary>
  public static String? GetTypeface(SupplementalFont? openXmlElement)
  {
    return openXmlElement?.Typeface?.Value;
  }

  public static void SetTypeface(SupplementalFont? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Typeface = new StringValue { Value = value };
      else
        openXmlElement.Typeface = null;
  }

  public static DocumentModel.Drawings.SupplementalFont? CreateModelElement(SupplementalFont? openXmlElement)
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
    where OpenXmlElementType : SupplementalFont, new()
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