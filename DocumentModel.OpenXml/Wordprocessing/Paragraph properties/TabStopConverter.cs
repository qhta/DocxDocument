namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Custom Tab Stop.
/// </summary>
public static class TabStopConverter
{
  /// <summary>
  /// Tab Stop Type
  /// </summary>
  private static DMW.TabStopKind? GetVal(DXW.TabStop openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.TabStopValues, DMW.TabStopKind>(openXmlElement?.Val?.Value);
  }
  
  private static bool CmpVal(DXW.TabStop openXmlElement, DMW.TabStopKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.TabStopValues, DMW.TabStopKind>(openXmlElement?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetVal(DXW.TabStop openXmlElement, DMW.TabStopKind? value)
  {
    openXmlElement.Val = EnumValueConverter.CreateEnumValue<DXW.TabStopValues, DMW.TabStopKind>(value);
  }
  
  /// <summary>
  /// Tab Leader Character
  /// </summary>
  private static DMW.TabStopLeaderCharKind? GetLeader(DXW.TabStop openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.TabStopLeaderCharValues, DMW.TabStopLeaderCharKind>(openXmlElement?.Leader?.Value);
  }
  
  private static bool CmpLeader(DXW.TabStop openXmlElement, DMW.TabStopLeaderCharKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.TabStopLeaderCharValues, DMW.TabStopLeaderCharKind>(openXmlElement?.Leader?.Value, value, diffs, objName, propName);
  }
  
  private static void SetLeader(DXW.TabStop openXmlElement, DMW.TabStopLeaderCharKind? value)
  {
    openXmlElement.Leader = EnumValueConverter.CreateEnumValue<DXW.TabStopLeaderCharValues, DMW.TabStopLeaderCharKind>(value);
  }
  
  /// <summary>
  /// Tab Stop Position
  /// </summary>
  private static Int32? GetPosition(DXW.TabStop openXmlElement)
  {
    return openXmlElement?.Position?.Value;
  }
  
  private static bool CmpPosition(DXW.TabStop openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Position?.Value == value) return true;
    diffs?.Add(objName, "Position", openXmlElement?.Position?.Value, value);
    return false;
  }
  
  private static void SetPosition(DXW.TabStop openXmlElement, Int32? value)
  {
    openXmlElement.Position = value;
  }
  
  public static DMW.TabStop? CreateModelElement(DXW.TabStop? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TabStop();
      value.Val = GetVal(openXmlElement);
      value.Leader = GetLeader(openXmlElement);
      value.Position = GetPosition(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TabStop? openXmlElement, DMW.TabStop? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVal(openXmlElement, value.Val, diffs, objName, propName))
        ok = false;
      if (!CmpLeader(openXmlElement, value.Leader, diffs, objName, propName))
        ok = false;
      if (!CmpPosition(openXmlElement, value.Position, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static DXW.TabStop CreateOpenXmlElement(DMW.TabStop value)
  {
    var openXmlElement = new DXW.TabStop();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXW.TabStop openXmlElement, DMW.TabStop value)
  {
    SetVal(openXmlElement, value?.Val);
    SetLeader(openXmlElement, value?.Leader);
    SetPosition(openXmlElement, value?.Position);
    return true;
  }
}
