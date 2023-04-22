namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the DocGrid Class.
/// </summary>
public static class DocGridConverter
{
  /// <summary>
  /// Document Grid Type
  /// </summary>
  private static DMW.DocGridKind? GetType(DXW.DocGrid openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.DocGridValues, DMW.DocGridKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXW.DocGrid openXmlElement, DMW.DocGridKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DXW.DocGridValues, DMW.DocGridKind>(openXmlElement?.Type?.Value, value, diffs, objName);
  }
  
  private static void SetType(DXW.DocGrid openXmlElement, DMW.DocGridKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DXW.DocGridValues, DMW.DocGridKind>(value);
  }
  
  /// <summary>
  /// Document Grid Line Pitch
  /// </summary>
  private static Int32? GetLinePitch(DXW.DocGrid openXmlElement)
  {
    return openXmlElement?.LinePitch?.Value;
  }
  
  private static bool CmpLinePitch(DXW.DocGrid openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.LinePitch?.Value == value) return true;
    diffs?.Add(objName, "LinePitch", openXmlElement?.LinePitch?.Value, value);
    return false;
  }
  
  private static void SetLinePitch(DXW.DocGrid openXmlElement, Int32? value)
  {
    openXmlElement.LinePitch = value;
  }
  
  /// <summary>
  /// Document Grid Character Pitch
  /// </summary>
  private static Int32? GetCharacterSpace(DXW.DocGrid openXmlElement)
  {
    return openXmlElement?.CharacterSpace?.Value;
  }
  
  private static bool CmpCharacterSpace(DXW.DocGrid openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.CharacterSpace?.Value == value) return true;
    diffs?.Add(objName, "CharacterSpace", openXmlElement?.CharacterSpace?.Value, value);
    return false;
  }
  
  private static void SetCharacterSpace(DXW.DocGrid openXmlElement, Int32? value)
  {
    openXmlElement.CharacterSpace = value;
  }
  
  public static DMW.DocGrid? CreateModelElement(DXW.DocGrid? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.DocGrid();
      value.Type = GetType(openXmlElement);
      value.LinePitch = GetLinePitch(openXmlElement);
      value.CharacterSpace = GetCharacterSpace(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.DocGrid? openXmlElement, DMW.DocGrid? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpType(openXmlElement, value.Type, diffs, objName))
        ok = false;
      if (!CmpLinePitch(openXmlElement, value.LinePitch, diffs, objName))
        ok = false;
      if (!CmpCharacterSpace(openXmlElement, value.CharacterSpace, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.DocGrid value)
    where OpenXmlElementType: DXW.DocGrid, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.DocGrid openXmlElement, DMW.DocGrid value)
  {
    SetType(openXmlElement, value?.Type);
    SetLinePitch(openXmlElement, value?.LinePitch);
    SetCharacterSpace(openXmlElement, value?.CharacterSpace);
  }
}
