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
    return openXmlElement?.Font?.Value == value;
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
  private static UInt16? GetChar(DXW.SymbolChar openXmlElement)
  {
    if (openXmlElement.Char?.Value != null)
      return UInt16.Parse(openXmlElement.Char.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static bool CmpChar(DXW.SymbolChar openXmlElement, UInt16? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement.Char?.Value != null)
      return UInt16.Parse(openXmlElement.Char.Value, NumberStyles.HexNumber) == value;
    return openXmlElement == null && value == null;
  }
  
  private static void SetChar(DXW.SymbolChar openXmlElement, UInt16? value)
  {
      if (value != null)
        openXmlElement.Char = ((UInt16)value).ToString("X4");
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
    return openXmlElement == null && value == null;
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
