using DocumentFormat.OpenXml.Office.Word;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the MacroWllType Class.
/// </summary>
public static class MacroWllTypeConverter
{
  /// <summary>
  ///   macroName
  /// </summary>
  public static String? GetMacroName(MacroWllType? openXmlElement)
  {
    return openXmlElement?.MacroName?.Value;
  }

  public static void SetMacroName(MacroWllType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.MacroName = new StringValue { Value = value };
      else
        openXmlElement.MacroName = null;
  }

  public static DocumentModel.Wordprocessing.MacroWllType? CreateModelElement(MacroWllType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.MacroWllType();
      value.MacroName = GetMacroName(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.MacroWllType? value)
    where OpenXmlElementType : MacroWllType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMacroName(openXmlElement, value?.MacroName);
      return openXmlElement;
    }
    return default;
  }
}