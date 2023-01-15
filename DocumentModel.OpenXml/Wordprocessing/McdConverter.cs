using DocumentFormat.OpenXml.Office.Word;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the Mcd Class.
/// </summary>
public static class McdConverter
{
  /// <summary>
  ///   macroName
  /// </summary>
  public static String? GetMacroName(Mcd? openXmlElement)
  {
    return openXmlElement?.MacroName?.Value;
  }

  public static void SetMacroName(Mcd? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.MacroName = new StringValue { Value = value };
      else
        openXmlElement.MacroName = null;
  }

  /// <summary>
  ///   name
  /// </summary>
  public static String? GetName(Mcd? openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }

  public static void SetName(Mcd? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Name = new StringValue { Value = value };
      else
        openXmlElement.Name = null;
  }

  /// <summary>
  ///   menuHelp
  /// </summary>
  public static String? GetMenuHelp(Mcd? openXmlElement)
  {
    return openXmlElement?.MenuHelp?.Value;
  }

  public static void SetMenuHelp(Mcd? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.MenuHelp = new StringValue { Value = value };
      else
        openXmlElement.MenuHelp = null;
  }

  /// <summary>
  ///   bEncrypt
  /// </summary>
  public static Byte[]? GetBEncrypt(Mcd? openXmlElement)
  {
    if (openXmlElement?.BEncrypt?.Value != null)
      return Convert.FromHexString(openXmlElement.BEncrypt.Value);
    return null;
  }

  public static void SetBEncrypt(Mcd? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.BEncrypt = Convert.ToHexString(value);
      else
        openXmlElement.BEncrypt = null;
    }
  }

  /// <summary>
  ///   cmg
  /// </summary>
  public static Byte[]? GetCmg(Mcd? openXmlElement)
  {
    if (openXmlElement?.Cmg?.Value != null)
      return Convert.FromHexString(openXmlElement.Cmg.Value);
    return null;
  }

  public static void SetCmg(Mcd? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.Cmg = Convert.ToHexString(value);
      else
        openXmlElement.Cmg = null;
    }
  }

  public static DocumentModel.Wordprocessing.Mcd? CreateModelElement(Mcd? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Mcd();
      value.MacroName = GetMacroName(openXmlElement);
      value.Name = GetName(openXmlElement);
      value.MenuHelp = GetMenuHelp(openXmlElement);
      value.BEncrypt = GetBEncrypt(openXmlElement);
      value.Cmg = GetCmg(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Mcd? value)
    where OpenXmlElementType : Mcd, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMacroName(openXmlElement, value?.MacroName);
      SetName(openXmlElement, value?.Name);
      SetMenuHelp(openXmlElement, value?.MenuHelp);
      SetBEncrypt(openXmlElement, value?.BEncrypt);
      SetCmg(openXmlElement, value?.Cmg);
      return openXmlElement;
    }
    return default;
  }
}