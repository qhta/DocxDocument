namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Mcd Class.
/// </summary>
public static class McdConverter
{
  /// <summary>
  /// macroName
  /// </summary>
  private static String? GetMacroName(DXOW.Mcd openXmlElement)
  {
    return openXmlElement?.MacroName?.Value;
  }
  
  private static void SetMacroName(DXOW.Mcd openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.MacroName = new StringValue { Value = value };
    else
      openXmlElement.MacroName = null;
  }
  
  /// <summary>
  /// name
  /// </summary>
  private static String? GetName(DXOW.Mcd openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static void SetName(DXOW.Mcd openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// menuHelp
  /// </summary>
  private static String? GetMenuHelp(DXOW.Mcd openXmlElement)
  {
    return openXmlElement?.MenuHelp?.Value;
  }
  
  private static void SetMenuHelp(DXOW.Mcd openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.MenuHelp = new StringValue { Value = value };
    else
      openXmlElement.MenuHelp = null;
  }
  
  /// <summary>
  /// bEncrypt
  /// </summary>
  private static Byte? GetBEncrypt(DXOW.Mcd openXmlElement)
  {
    if (openXmlElement.BEncrypt?.Value != null)
      return Byte.Parse(openXmlElement.BEncrypt.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetBEncrypt(DXOW.Mcd openXmlElement, Byte? value)
  {
      if (value != null)
        openXmlElement.BEncrypt = ((UInt16)value).ToString("X2");
      else
        openXmlElement.BEncrypt = null;
  }
  
  /// <summary>
  /// cmg
  /// </summary>
  private static Byte? GetCmg(DXOW.Mcd openXmlElement)
  {
    if (openXmlElement.Cmg?.Value != null)
      return Byte.Parse(openXmlElement.Cmg.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetCmg(DXOW.Mcd openXmlElement, Byte? value)
  {
      if (value != null)
        openXmlElement.Cmg = ((UInt16)value).ToString("X2");
      else
        openXmlElement.Cmg = null;
  }
  
  public static DMW.Mcd? CreateModelElement(DXOW.Mcd? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Mcd();
      value.MacroName = GetMacroName(openXmlElement);
      value.Name = GetName(openXmlElement);
      value.MenuHelp = GetMenuHelp(openXmlElement);
      value.BEncrypt = GetBEncrypt(openXmlElement);
      value.Cmg = GetCmg(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Mcd? value)
    where OpenXmlElementType: DXOW.Mcd, new()
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
