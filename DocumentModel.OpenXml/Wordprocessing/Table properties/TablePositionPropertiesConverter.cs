namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TablePositionProperties Class.
/// </summary>
public static class TablePositionPropertiesConverter
{
  /// <summary>
  /// Distance From Left of Table to Text
  private static Int16? GetLeftFromText(DXW.TablePositionProperties openXmlElement)
  {
    return openXmlElement?.LeftFromText?.Value;
  }
  
  private static bool CmpLeftFromText(DXW.TablePositionProperties openXmlElement, Int16? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.LeftFromText?.Value == value) return true;
    diffs?.Add(objName, "LeftFromText", openXmlElement?.LeftFromText?.Value, value);
    return false;
  }
  
  private static void SetLeftFromText(DXW.TablePositionProperties openXmlElement, Int16? value)
  {
    openXmlElement.LeftFromText = value;
  }
  
  /// <summary>
  /// (Distance From Right of Table to Text
  private static Int16? GetRightFromText(DXW.TablePositionProperties openXmlElement)
  {
    return openXmlElement?.RightFromText?.Value;
  }
  
  private static bool CmpRightFromText(DXW.TablePositionProperties openXmlElement, Int16? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RightFromText?.Value == value) return true;
    diffs?.Add(objName, "RightFromText", openXmlElement?.RightFromText?.Value, value);
    return false;
  }
  
  private static void SetRightFromText(DXW.TablePositionProperties openXmlElement, Int16? value)
  {
    openXmlElement.RightFromText = value;
  }
  
  /// <summary>
  /// Distance From Top of Table to Text
  private static Int16? GetTopFromText(DXW.TablePositionProperties openXmlElement)
  {
    return openXmlElement?.TopFromText?.Value;
  }
  
  private static bool CmpTopFromText(DXW.TablePositionProperties openXmlElement, Int16? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.TopFromText?.Value == value) return true;
    diffs?.Add(objName, "TopFromText", openXmlElement?.TopFromText?.Value, value);
    return false;
  }
  
  private static void SetTopFromText(DXW.TablePositionProperties openXmlElement, Int16? value)
  {
    openXmlElement.TopFromText = value;
  }
  
  /// <summary>
  /// Distance From Bottom of Table to Text
  private static Int16? GetBottomFromText(DXW.TablePositionProperties openXmlElement)
  {
    return openXmlElement?.BottomFromText?.Value;
  }
  
  private static bool CmpBottomFromText(DXW.TablePositionProperties openXmlElement, Int16? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.BottomFromText?.Value == value) return true;
    diffs?.Add(objName, "BottomFromText", openXmlElement?.BottomFromText?.Value, value);
    return false;
  }
  
  private static void SetBottomFromText(DXW.TablePositionProperties openXmlElement, Int16? value)
  {
    openXmlElement.BottomFromText = value;
  }
  
  /// <summary>
  /// Table Vertical Anchor
  private static DMW.VerticalAnchorKind? GetVerticalAnchor(DXW.TablePositionProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.VerticalAnchorValues, DMW.VerticalAnchorKind>(openXmlElement?.VerticalAnchor?.Value);
  }
  
  private static bool CmpVerticalAnchor(DXW.TablePositionProperties openXmlElement, DMW.VerticalAnchorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DXW.VerticalAnchorValues, DMW.VerticalAnchorKind>(openXmlElement?.VerticalAnchor?.Value, value, diffs, objName);
  }
  
  private static void SetVerticalAnchor(DXW.TablePositionProperties openXmlElement, DMW.VerticalAnchorKind? value)
  {
    openXmlElement.VerticalAnchor = EnumValueConverter.CreateEnumValue<DXW.VerticalAnchorValues, DMW.VerticalAnchorKind>(value);
  }
  
  /// <summary>
  /// Table Horizontal Anchor
  private static DMW.HorizontalAnchorKind? GetHorizontalAnchor(DXW.TablePositionProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.HorizontalAnchorValues, DMW.HorizontalAnchorKind>(openXmlElement?.HorizontalAnchor?.Value);
  }
  
  private static bool CmpHorizontalAnchor(DXW.TablePositionProperties openXmlElement, DMW.HorizontalAnchorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DXW.HorizontalAnchorValues, DMW.HorizontalAnchorKind>(openXmlElement?.HorizontalAnchor?.Value, value, diffs, objName);
  }
  
  private static void SetHorizontalAnchor(DXW.TablePositionProperties openXmlElement, DMW.HorizontalAnchorKind? value)
  {
    openXmlElement.HorizontalAnchor = EnumValueConverter.CreateEnumValue<DXW.HorizontalAnchorValues, DMW.HorizontalAnchorKind>(value);
  }
  
  /// <summary>
  /// Relative Horizontal Alignment From Anchor
  private static DMW.HorizontalAlignmentKind? GetTablePositionXAlignment(DXW.TablePositionProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.HorizontalAlignmentValues, DMW.HorizontalAlignmentKind>(openXmlElement?.TablePositionXAlignment?.Value);
  }
  
  private static bool CmpTablePositionXAlignment(DXW.TablePositionProperties openXmlElement, DMW.HorizontalAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DXW.HorizontalAlignmentValues, DMW.HorizontalAlignmentKind>(openXmlElement?.TablePositionXAlignment?.Value, value, diffs, objName);
  }
  
  private static void SetTablePositionXAlignment(DXW.TablePositionProperties openXmlElement, DMW.HorizontalAlignmentKind? value)
  {
    openXmlElement.TablePositionXAlignment = EnumValueConverter.CreateEnumValue<DXW.HorizontalAlignmentValues, DMW.HorizontalAlignmentKind>(value);
  }
  
  /// <summary>
  /// Absolute Horizontal Distance From Anchor
  private static Int32? GetTablePositionX(DXW.TablePositionProperties openXmlElement)
  {
    return openXmlElement?.TablePositionX?.Value;
  }
  
  private static bool CmpTablePositionX(DXW.TablePositionProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.TablePositionX?.Value == value) return true;
    diffs?.Add(objName, "TablePositionX", openXmlElement?.TablePositionX?.Value, value);
    return false;
  }
  
  private static void SetTablePositionX(DXW.TablePositionProperties openXmlElement, Int32? value)
  {
    openXmlElement.TablePositionX = value;
  }
  
  /// <summary>
  /// Relative Vertical Alignment from Anchor
  private static DMW.VerticalAlignmentKind? GetTablePositionYAlignment(DXW.TablePositionProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.VerticalAlignmentValues, DMW.VerticalAlignmentKind>(openXmlElement?.TablePositionYAlignment?.Value);
  }
  
  private static bool CmpTablePositionYAlignment(DXW.TablePositionProperties openXmlElement, DMW.VerticalAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DXW.VerticalAlignmentValues, DMW.VerticalAlignmentKind>(openXmlElement?.TablePositionYAlignment?.Value, value, diffs, objName);
  }
  
  private static void SetTablePositionYAlignment(DXW.TablePositionProperties openXmlElement, DMW.VerticalAlignmentKind? value)
  {
    openXmlElement.TablePositionYAlignment = EnumValueConverter.CreateEnumValue<DXW.VerticalAlignmentValues, DMW.VerticalAlignmentKind>(value);
  }
  
  /// <summary>
  /// Absolute Vertical Distance From Anchor
  private static Int32? GetTablePositionY(DXW.TablePositionProperties openXmlElement)
  {
    return openXmlElement?.TablePositionY?.Value;
  }
  
  private static bool CmpTablePositionY(DXW.TablePositionProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.TablePositionY?.Value == value) return true;
    diffs?.Add(objName, "TablePositionY", openXmlElement?.TablePositionY?.Value, value);
    return false;
  }
  
  private static void SetTablePositionY(DXW.TablePositionProperties openXmlElement, Int32? value)
  {
    openXmlElement.TablePositionY = value;
  }
  
  public static DMW.TablePositionProperties? CreateModelElement(DXW.TablePositionProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TablePositionProperties();
      value.LeftFromText = GetLeftFromText(openXmlElement);
      value.RightFromText = GetRightFromText(openXmlElement);
      value.TopFromText = GetTopFromText(openXmlElement);
      value.BottomFromText = GetBottomFromText(openXmlElement);
      value.VerticalAnchor = GetVerticalAnchor(openXmlElement);
      value.HorizontalAnchor = GetHorizontalAnchor(openXmlElement);
      value.TablePositionXAlignment = GetTablePositionXAlignment(openXmlElement);
      value.TablePositionX = GetTablePositionX(openXmlElement);
      value.TablePositionYAlignment = GetTablePositionYAlignment(openXmlElement);
      value.TablePositionY = GetTablePositionY(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TablePositionProperties? openXmlElement, DMW.TablePositionProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLeftFromText(openXmlElement, value.LeftFromText, diffs, objName))
        ok = false;
      if (!CmpRightFromText(openXmlElement, value.RightFromText, diffs, objName))
        ok = false;
      if (!CmpTopFromText(openXmlElement, value.TopFromText, diffs, objName))
        ok = false;
      if (!CmpBottomFromText(openXmlElement, value.BottomFromText, diffs, objName))
        ok = false;
      if (!CmpVerticalAnchor(openXmlElement, value.VerticalAnchor, diffs, objName))
        ok = false;
      if (!CmpHorizontalAnchor(openXmlElement, value.HorizontalAnchor, diffs, objName))
        ok = false;
      if (!CmpTablePositionXAlignment(openXmlElement, value.TablePositionXAlignment, diffs, objName))
        ok = false;
      if (!CmpTablePositionX(openXmlElement, value.TablePositionX, diffs, objName))
        ok = false;
      if (!CmpTablePositionYAlignment(openXmlElement, value.TablePositionYAlignment, diffs, objName))
        ok = false;
      if (!CmpTablePositionY(openXmlElement, value.TablePositionY, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TablePositionProperties value)
    where OpenXmlElementType: DXW.TablePositionProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TablePositionProperties openXmlElement, DMW.TablePositionProperties value)
  {
    SetLeftFromText(openXmlElement, value?.LeftFromText);
    SetRightFromText(openXmlElement, value?.RightFromText);
    SetTopFromText(openXmlElement, value?.TopFromText);
    SetBottomFromText(openXmlElement, value?.BottomFromText);
    SetVerticalAnchor(openXmlElement, value?.VerticalAnchor);
    SetHorizontalAnchor(openXmlElement, value?.HorizontalAnchor);
    SetTablePositionXAlignment(openXmlElement, value?.TablePositionXAlignment);
    SetTablePositionX(openXmlElement, value?.TablePositionX);
    SetTablePositionYAlignment(openXmlElement, value?.TablePositionYAlignment);
    SetTablePositionY(openXmlElement, value?.TablePositionY);
  }
}
