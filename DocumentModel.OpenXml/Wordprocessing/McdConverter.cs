namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Mcd Class converter from/to OpenXml.
///</summary>
public static class McdConverter
{
  /// <summary>
  /// macroName
  /// </summary>
  private static String? GetMacroName(DXOW.Mcd openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.MacroName);
  }
  
  private static bool CmpMacroName(DXOW.Mcd openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.MacroName, value, diffs, objName, "MacroName");
  }
  
  private static void SetMacroName(DXOW.Mcd openXmlElement, String? value)
  {
    openXmlElement.MacroName = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// name
  /// </summary>
  private static String? GetName(DXOW.Mcd openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Name);
  }
  
  private static bool CmpName(DXOW.Mcd openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Name, value, diffs, objName, "Name");
  }
  
  private static void SetName(DXOW.Mcd openXmlElement, String? value)
  {
    openXmlElement.Name = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// menuHelp
  /// </summary>
  private static String? GetMenuHelp(DXOW.Mcd openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.MenuHelp);
  }
  
  private static bool CmpMenuHelp(DXOW.Mcd openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.MenuHelp, value, diffs, objName, "MenuHelp");
  }
  
  private static void SetMenuHelp(DXOW.Mcd openXmlElement, String? value)
  {
    openXmlElement.MenuHelp = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// bEncrypt
  /// </summary>
  private static DM.HexChar? GetBEncrypt(DXOW.Mcd openXmlElement)
  {
    if (openXmlElement?.BEncrypt?.Value != null)
      return HexCharConverter.GetValue(openXmlElement.BEncrypt.Value);
    return null;
  }
  
  private static bool CmpBEncrypt(DXOW.Mcd openXmlElement, DM.HexChar? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.BEncrypt?.Value != null)
      if (HexCharConverter.GetValue(openXmlElement.BEncrypt.Value).Equals(value))
        return true;
    if (openXmlElement == null && openXmlElement?.BEncrypt?.Value == null && value is null) return true;
    diffs?.Add(objName, "BEncrypt", openXmlElement?.BEncrypt?.Value, value);
    return false;
  }
  
  private static void SetBEncrypt(DXOW.Mcd openXmlElement, DM.HexChar? value)
  {
    if (value is not null)
      openXmlElement.BEncrypt = value.ToString();
    else
      openXmlElement.BEncrypt = null;
  }
  
  /// <summary>
  /// cmg
  /// </summary>
  private static DM.HexChar? GetCmg(DXOW.Mcd openXmlElement)
  {
    if (openXmlElement?.Cmg?.Value != null)
      return HexCharConverter.GetValue(openXmlElement.Cmg.Value);
    return null;
  }
  
  private static bool CmpCmg(DXOW.Mcd openXmlElement, DM.HexChar? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Cmg?.Value != null)
      if (HexCharConverter.GetValue(openXmlElement.Cmg.Value).Equals(value))
        return true;
    if (openXmlElement == null && openXmlElement?.Cmg?.Value == null && value is null) return true;
    diffs?.Add(objName, "Cmg", openXmlElement?.Cmg?.Value, value);
    return false;
  }
  
  private static void SetCmg(DXOW.Mcd openXmlElement, DM.HexChar? value)
  {
    if (value is not null)
      openXmlElement.Cmg = value.ToString();
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Mcd value)
    where OpenXmlElementType: DXOW.Mcd, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOW.Mcd openXmlElement, DMW.Mcd value)
  {
    SetMacroName(openXmlElement, value?.MacroName);
    SetName(openXmlElement, value?.Name);
    SetMenuHelp(openXmlElement, value?.MenuHelp);
    SetBEncrypt(openXmlElement, value?.BEncrypt);
    SetCmg(openXmlElement, value?.Cmg);
  }
}
