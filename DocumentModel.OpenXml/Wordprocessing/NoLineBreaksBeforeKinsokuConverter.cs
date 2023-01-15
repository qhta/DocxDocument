using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Custom Set Of Characters Which Cannot Begin A Line.
/// </summary>
public static class NoLineBreaksBeforeKinsokuConverter
{
  /// <summary>
  ///   lang
  /// </summary>
  public static String? GetLanguage(NoLineBreaksBeforeKinsoku? openXmlElement)
  {
    return openXmlElement?.Language?.Value;
  }

  public static void SetLanguage(NoLineBreaksBeforeKinsoku? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Language = new StringValue { Value = value };
      else
        openXmlElement.Language = null;
  }

  /// <summary>
  ///   val
  /// </summary>
  public static String? GetVal(NoLineBreaksBeforeKinsoku? openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }

  public static void SetVal(NoLineBreaksBeforeKinsoku? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Val = new StringValue { Value = value };
      else
        openXmlElement.Val = null;
  }

  public static DocumentModel.Wordprocessing.NoLineBreaksBeforeKinsoku? CreateModelElement(NoLineBreaksBeforeKinsoku? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.NoLineBreaksBeforeKinsoku();
      value.Language = GetLanguage(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.NoLineBreaksBeforeKinsoku? value)
    where OpenXmlElementType : NoLineBreaksBeforeKinsoku, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLanguage(openXmlElement, value?.Language);
      SetVal(openXmlElement, value?.Val);
      return openXmlElement;
    }
    return default;
  }
}