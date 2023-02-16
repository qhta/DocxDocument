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
  
  private static bool CmpMacroName(DXOW.Mcd openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.MacroName?.Value == value) return true;
    diffs?.Add(objName, "MacroName", openXmlElement?.MacroName?.Value, value);
    return false;
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
  
  private static bool CmpName(DXOW.Mcd openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Name?.Value == value) return true;
    diffs?.Add(objName, "Name", openXmlElement?.Name?.Value, value);
    return false;
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
  
  private static bool CmpMenuHelp(DXOW.Mcd openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.MenuHelp?.Value == value) return true;
    diffs?.Add(objName, "MenuHelp", openXmlElement?.MenuHelp?.Value, value);
    return false;
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
  private static DM.HexInt? GetBEncrypt(DXOW.Mcd openXmlElement)
  {
    if (openXmlElement?.BEncrypt?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.BEncrypt.Value);
    return null;
  }
  
  private static bool CmpBEncrypt(DXOW.Mcd openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.BEncrypt?.Value != null)
      if (HexIntConverter.GetValue(openXmlElement.BEncrypt.Value) == value)
        return true;
    if (openXmlElement == null && openXmlElement?.BEncrypt?.Value == null && value == null) return true;
    diffs?.Add(objName, "BEncrypt", openXmlElement?.BEncrypt?.Value, value);
    return false;
  }
  
  private static void SetBEncrypt(DXOW.Mcd openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.BEncrypt = value.ToString();
    else
      openXmlElement.BEncrypt = null;
  }
  
  /// <summary>
  /// cmg
  /// </summary>
  private static DM.HexBinary? GetCmg(DXOW.Mcd openXmlElement)
  {
    if (openXmlElement?.Cmg?.Value != null)
      return Convert.FromHexString(openXmlElement.Cmg.Value);
    return null;
  }
  
  private static bool CmpCmg(DXOW.Mcd openXmlElement, DM.HexBinary? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Cmg?.Value != null && value != null)
      if (Convert.FromHexString(openXmlElement.Cmg.Value).SequenceEqual((byte[])value))
        return true;
    if (openXmlElement == null && openXmlElement?.Cmg?.Value == null && value == null) return true;
    diffs?.Add(objName, "Cmg", openXmlElement?.Cmg?.Value, value);
    return false;
  }
  
  private static void SetCmg(DXOW.Mcd openXmlElement, DM.HexBinary? value)
  {
    if (value != null)
      openXmlElement.Cmg = Convert.ToHexString(value);
    else
      openXmlElement.Cmg = null;
  }
  
  public static DocumentModel.Wordprocessing.Mcd? CreateModelElement(DXOW.Mcd? openXmlElement)
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
  
  public static bool CompareModelElement(DXOW.Mcd? openXmlElement, DMW.Mcd? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpMacroName(openXmlElement, value.MacroName, diffs, objName))
        ok = false;
      if (!CmpName(openXmlElement, value.Name, diffs, objName))
        ok = false;
      if (!CmpMenuHelp(openXmlElement, value.MenuHelp, diffs, objName))
        ok = false;
      if (!CmpBEncrypt(openXmlElement, value.BEncrypt, diffs, objName))
        ok = false;
      if (!CmpCmg(openXmlElement, value.Cmg, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
