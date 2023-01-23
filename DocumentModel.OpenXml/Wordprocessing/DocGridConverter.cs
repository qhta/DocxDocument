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
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DocGridValues, DMW.DocGridKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXW.DocGrid openXmlElement, DMW.DocGridKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.DocGridValues, DMW.DocGridKind>(openXmlElement?.Type?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetType(DXW.DocGrid openXmlElement, DMW.DocGridKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.DocGridValues, DMW.DocGridKind>(value);
  }
  
  /// <summary>
  /// Document Grid Line Pitch
  /// </summary>
  private static Int32? GetLinePitch(DXW.DocGrid openXmlElement)
  {
    return openXmlElement.LinePitch?.Value;
  }
  
  private static bool CmpLinePitch(DXW.DocGrid openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.LinePitch?.Value == value;
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
    return openXmlElement.CharacterSpace?.Value;
  }
  
  private static bool CmpCharacterSpace(DXW.DocGrid openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.CharacterSpace?.Value == value;
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.DocGrid? value)
    where OpenXmlElementType: DXW.DocGrid, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetLinePitch(openXmlElement, value?.LinePitch);
      SetCharacterSpace(openXmlElement, value?.CharacterSpace);
      return openXmlElement;
    }
    return default;
  }
}
