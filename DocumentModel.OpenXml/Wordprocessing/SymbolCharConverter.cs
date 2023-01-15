using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Symbol Character.
/// </summary>
public static class SymbolCharConverter
{
  /// <summary>
  ///   Symbol Character Font
  /// </summary>
  public static String? GetFont(SymbolChar? openXmlElement)
  {
    return openXmlElement?.Font?.Value;
  }

  public static void SetFont(SymbolChar? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Font = new StringValue { Value = value };
      else
        openXmlElement.Font = null;
  }

  /// <summary>
  ///   Symbol Character Code
  /// </summary>
  public static Byte[]? GetChar(SymbolChar? openXmlElement)
  {
    if (openXmlElement?.Char?.Value != null)
      return Convert.FromHexString(openXmlElement.Char.Value);
    return null;
  }

  public static void SetChar(SymbolChar? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.Char = Convert.ToHexString(value);
      else
        openXmlElement.Char = null;
    }
  }

  public static DocumentModel.Wordprocessing.SymbolChar? CreateModelElement(SymbolChar? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.SymbolChar();
      value.Font = GetFont(openXmlElement);
      value.Char = GetChar(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.SymbolChar? value)
    where OpenXmlElementType : SymbolChar, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFont(openXmlElement, value?.Font);
      SetChar(openXmlElement, value?.Char);
      return openXmlElement;
    }
    return default;
  }
}