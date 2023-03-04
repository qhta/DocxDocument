namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Symbol Character.
/// </summary>
public static class SymbolCharConverter
{
  /// <summary>
  /// Symbol Character Font
  /// </summary>
  private static String? GetFont(DXW.SymbolChar openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Font);
  }
  
  private static bool CmpFont(DXW.SymbolChar openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Font, value, diffs, objName, "Font");
  }
  
  private static void SetFont(DXW.SymbolChar openXmlElement, String? value)
  {
    openXmlElement.Font = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Symbol Character Code
  /// </summary>
  private static DM.HexChar? GetChar(DXW.SymbolChar openXmlElement)
  {
    if (openXmlElement?.Char?.Value != null)
      return HexCharConverter.GetValue(openXmlElement.Char.Value);
    return null;
  }
  
  private static bool CmpChar(DXW.SymbolChar openXmlElement, DM.HexChar? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Char?.Value != null)
      if (HexCharConverter.GetValue(openXmlElement.Char.Value).Equals(value))
        return true;
    if (openXmlElement == null && openXmlElement?.Char?.Value == null && value is null) return true;
    diffs?.Add(objName, "Char", openXmlElement?.Char?.Value, value);
    return false;
  }
  
  private static void SetChar(DXW.SymbolChar openXmlElement, DM.HexChar? value)
  {
    if (value is not null)
      openXmlElement.Char = value.ToString();
    else
      openXmlElement.Char = null;
  }
  
  public static DMW.SymbolChar? CreateModelElement(DXW.SymbolChar? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.SymbolChar();
      value.Font = GetFont(openXmlElement);
      value.Char = GetChar(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.SymbolChar? openXmlElement, DMW.SymbolChar? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFont(openXmlElement, value.Font, diffs, objName))
        ok = false;
      if (!CmpChar(openXmlElement, value.Char, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static DXW.SymbolChar CreateOpenXmlElement(DMW.SymbolChar value)
  {
    var openXmlElement = new DXW.SymbolChar();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.SymbolChar openXmlElement, DMW.SymbolChar value)
  {
    SetFont(openXmlElement, value?.Font);
    SetChar(openXmlElement, value?.Char);
  }
}
