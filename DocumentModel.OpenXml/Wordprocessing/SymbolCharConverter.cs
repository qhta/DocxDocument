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
    return openXmlElement?.Font?.Value;
  }
  
  private static bool CmpFont(DXW.SymbolChar openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Font?.Value == value) return true;
    diffs?.Add(objName, "Font", openXmlElement?.Font?.Value, value);
    return false;
  }
  
  private static void SetFont(DXW.SymbolChar openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Font = new StringValue { Value = value };
    else
      openXmlElement.Font = null;
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
      if (HexCharConverter.GetValue(openXmlElement.Char.Value) == value)
        return true;
    if (openXmlElement == null && openXmlElement?.Char?.Value == null && value == null) return true;
    diffs?.Add(objName, "Char", openXmlElement?.Char?.Value, value);
    return false;
  }
  
  private static void SetChar(DXW.SymbolChar openXmlElement, DM.HexChar? value)
  {
    if (value != null)
      openXmlElement.Char = value.ToString();
    else
      openXmlElement.Char = null;
  }
  
  public static DocumentModel.Wordprocessing.SymbolChar? CreateModelElement(DXW.SymbolChar? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.SymbolChar? value)
    where OpenXmlElementType: DXW.SymbolChar, new()
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
