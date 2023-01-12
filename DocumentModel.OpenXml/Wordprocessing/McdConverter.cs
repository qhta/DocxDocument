namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Mcd Class.
/// </summary>
public static class McdConverter
{
  /// <summary>
  /// macroName
  /// </summary>
  public static String? GetMacroName(DocumentFormat.OpenXml.Office.Word.Mcd? openXmlElement)
  {
    return openXmlElement?.MacroName?.Value;
  }
  
  public static void SetMacroName(DocumentFormat.OpenXml.Office.Word.Mcd? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.MacroName = new StringValue { Value = value };
      else
        openXmlElement.MacroName = null;
  }
  
  /// <summary>
  /// name
  /// </summary>
  public static String? GetName(DocumentFormat.OpenXml.Office.Word.Mcd? openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  public static void SetName(DocumentFormat.OpenXml.Office.Word.Mcd? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Name = new StringValue { Value = value };
      else
        openXmlElement.Name = null;
  }
  
  /// <summary>
  /// menuHelp
  /// </summary>
  public static String? GetMenuHelp(DocumentFormat.OpenXml.Office.Word.Mcd? openXmlElement)
  {
    return openXmlElement?.MenuHelp?.Value;
  }
  
  public static void SetMenuHelp(DocumentFormat.OpenXml.Office.Word.Mcd? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.MenuHelp = new StringValue { Value = value };
      else
        openXmlElement.MenuHelp = null;
  }
  
  /// <summary>
  /// bEncrypt
  /// </summary>
  public static Byte[]? GetBEncrypt(DocumentFormat.OpenXml.Office.Word.Mcd? openXmlElement)
  {
    if (openXmlElement?.BEncrypt?.Value != null)
      return Convert.FromHexString(openXmlElement.BEncrypt.Value);
    return null;
  }
  
  public static void SetBEncrypt(DocumentFormat.OpenXml.Office.Word.Mcd? openXmlElement, Byte[]? value)
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
  /// cmg
  /// </summary>
  public static Byte[]? GetCmg(DocumentFormat.OpenXml.Office.Word.Mcd? openXmlElement)
  {
    if (openXmlElement?.Cmg?.Value != null)
      return Convert.FromHexString(openXmlElement.Cmg.Value);
    return null;
  }
  
  public static void SetCmg(DocumentFormat.OpenXml.Office.Word.Mcd? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.Cmg = Convert.ToHexString(value);
      else
        openXmlElement.Cmg = null;
    }
  }
  
  public static DocumentModel.Wordprocessing.Mcd? CreateModelElement(DocumentFormat.OpenXml.Office.Word.Mcd? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.Word.Mcd, new()
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
