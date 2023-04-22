namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Absolute Position Tab Character.
/// </summary>
public static class PositionalTabConverter
{
  /// <summary>
  /// Positional Tab Stop Alignment
  /// </summary>
  private static DMW.AbsolutePositionTabAlignmentKind? GetAlignment(DXW.PositionalTab openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.AbsolutePositionTabAlignmentValues, DMW.AbsolutePositionTabAlignmentKind>(openXmlElement?.Alignment?.Value);
  }
  
  private static bool CmpAlignment(DXW.PositionalTab openXmlElement, DMW.AbsolutePositionTabAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DXW.AbsolutePositionTabAlignmentValues, DMW.AbsolutePositionTabAlignmentKind>(openXmlElement?.Alignment?.Value, value, diffs, objName);
  }
  
  private static void SetAlignment(DXW.PositionalTab openXmlElement, DMW.AbsolutePositionTabAlignmentKind? value)
  {
    openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<DXW.AbsolutePositionTabAlignmentValues, DMW.AbsolutePositionTabAlignmentKind>(value);
  }
  
  /// <summary>
  /// Positional Tab Base
  /// </summary>
  private static DMW.AbsolutePositionTabPositioningBaseKind? GetRelativeTo(DXW.PositionalTab openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.AbsolutePositionTabPositioningBaseValues, DMW.AbsolutePositionTabPositioningBaseKind>(openXmlElement?.RelativeTo?.Value);
  }
  
  private static bool CmpRelativeTo(DXW.PositionalTab openXmlElement, DMW.AbsolutePositionTabPositioningBaseKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DXW.AbsolutePositionTabPositioningBaseValues, DMW.AbsolutePositionTabPositioningBaseKind>(openXmlElement?.RelativeTo?.Value, value, diffs, objName);
  }
  
  private static void SetRelativeTo(DXW.PositionalTab openXmlElement, DMW.AbsolutePositionTabPositioningBaseKind? value)
  {
    openXmlElement.RelativeTo = EnumValueConverter.CreateEnumValue<DXW.AbsolutePositionTabPositioningBaseValues, DMW.AbsolutePositionTabPositioningBaseKind>(value);
  }
  
  /// <summary>
  /// Tab Leader Character
  /// </summary>
  private static DMW.AbsolutePositionTabLeaderCharKind? GetLeader(DXW.PositionalTab openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.AbsolutePositionTabLeaderCharValues, DMW.AbsolutePositionTabLeaderCharKind>(openXmlElement?.Leader?.Value);
  }
  
  private static bool CmpLeader(DXW.PositionalTab openXmlElement, DMW.AbsolutePositionTabLeaderCharKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DXW.AbsolutePositionTabLeaderCharValues, DMW.AbsolutePositionTabLeaderCharKind>(openXmlElement?.Leader?.Value, value, diffs, objName);
  }
  
  private static void SetLeader(DXW.PositionalTab openXmlElement, DMW.AbsolutePositionTabLeaderCharKind? value)
  {
    openXmlElement.Leader = EnumValueConverter.CreateEnumValue<DXW.AbsolutePositionTabLeaderCharValues, DMW.AbsolutePositionTabLeaderCharKind>(value);
  }
  
  public static DMW.PositionalTab? CreateModelElement(DXW.PositionalTab? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.PositionalTab();
      value.Alignment = GetAlignment(openXmlElement);
      value.RelativeTo = GetRelativeTo(openXmlElement);
      value.Leader = GetLeader(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.PositionalTab? openXmlElement, DMW.PositionalTab? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAlignment(openXmlElement, value.Alignment, diffs, objName))
        ok = false;
      if (!CmpRelativeTo(openXmlElement, value.RelativeTo, diffs, objName))
        ok = false;
      if (!CmpLeader(openXmlElement, value.Leader, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static DXW.PositionalTab CreateOpenXmlElement(DMW.PositionalTab value)
  {
    var openXmlElement = new DXW.PositionalTab();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXW.PositionalTab openXmlElement, DMW.PositionalTab value)
  {
    SetAlignment(openXmlElement, value?.Alignment);
    SetRelativeTo(openXmlElement, value?.RelativeTo);
    SetLeader(openXmlElement, value?.Leader);
    return true;
  }
}
