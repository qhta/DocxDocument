using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using Break = DocumentFormat.OpenXml.Wordprocessing.Break;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Break.
/// </summary>
public static class BreakConverter
{
  /// <summary>
  ///   Break Type
  /// </summary>
  public static BreakKind? GetType(Break? openXmlElement)
  {
    return EnumValueConverter.GetValue<BreakValues, BreakKind>(openXmlElement?.Type?.Value);
  }

  public static void SetType(Break? openXmlElement, BreakKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<BreakValues, BreakKind>(value);
  }

  /// <summary>
  ///   Restart Location For Text Wrapping Break
  /// </summary>
  public static BreakTextRestartLocationKind? GetClear(Break? openXmlElement)
  {
    return EnumValueConverter.GetValue<BreakTextRestartLocationValues, BreakTextRestartLocationKind>(openXmlElement?.Clear?.Value);
  }

  public static void SetClear(Break? openXmlElement, BreakTextRestartLocationKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Clear = EnumValueConverter.CreateEnumValue<BreakTextRestartLocationValues, BreakTextRestartLocationKind>(value);
  }

  public static DocumentModel.Wordprocessing.Break? CreateModelElement(Break? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Break();
      value.Type = GetType(openXmlElement);
      value.Clear = GetClear(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Break? value)
    where OpenXmlElementType : Break, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetClear(openXmlElement, value?.Clear);
      return openXmlElement;
    }
    return default;
  }
}