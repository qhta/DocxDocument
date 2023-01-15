using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Legacy Numbering Level Properties.
/// </summary>
public static class LegacyNumberingConverter
{
  /// <summary>
  ///   Use Legacy Numbering Properties
  /// </summary>
  public static Boolean? GetLegacy(LegacyNumbering? openXmlElement)
  {
    return openXmlElement?.Legacy?.Value;
  }

  public static void SetLegacy(LegacyNumbering? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Legacy = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.Legacy = null;
  }

  /// <summary>
  ///   Legacy Spacing
  /// </summary>
  public static String? GetLegacySpace(LegacyNumbering? openXmlElement)
  {
    return openXmlElement?.LegacySpace?.Value;
  }

  public static void SetLegacySpace(LegacyNumbering? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LegacySpace = new StringValue { Value = value };
      else
        openXmlElement.LegacySpace = null;
  }

  /// <summary>
  ///   Legacy Indent
  /// </summary>
  public static String? GetLegacyIndent(LegacyNumbering? openXmlElement)
  {
    return openXmlElement?.LegacyIndent?.Value;
  }

  public static void SetLegacyIndent(LegacyNumbering? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LegacyIndent = new StringValue { Value = value };
      else
        openXmlElement.LegacyIndent = null;
  }

  public static DocumentModel.Wordprocessing.LegacyNumbering? CreateModelElement(LegacyNumbering? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.LegacyNumbering();
      value.Legacy = GetLegacy(openXmlElement);
      value.LegacySpace = GetLegacySpace(openXmlElement);
      value.LegacyIndent = GetLegacyIndent(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.LegacyNumbering? value)
    where OpenXmlElementType : LegacyNumbering, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLegacy(openXmlElement, value?.Legacy);
      SetLegacySpace(openXmlElement, value?.LegacySpace);
      SetLegacyIndent(openXmlElement, value?.LegacyIndent);
      return openXmlElement;
    }
    return default;
  }
}