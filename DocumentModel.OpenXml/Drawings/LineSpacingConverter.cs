namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Line Spacing.
/// </summary>
public static class LineSpacingConverter
{
  private static Int32? GetSpacingPercent(DXDraw.LineSpacing openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.SpacingPercent>()?.Val);
  }
  
  private static bool CmpSpacingPercent(DXDraw.LineSpacing openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.SpacingPercent>()?.Val, value, diffs, objName, "SpacingPercent");
  }
  
  private static void SetSpacingPercent(DXDraw.LineSpacing openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.SpacingPercent,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetSpacingPoints(DXDraw.LineSpacing openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.SpacingPoints>()?.Val);
  }
  
  private static bool CmpSpacingPoints(DXDraw.LineSpacing openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.SpacingPoints>()?.Val, value, diffs, objName, "SpacingPoints");
  }
  
  private static void SetSpacingPoints(DXDraw.LineSpacing openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.SpacingPoints,System.Int32>(openXmlElement, value);
  }
  
  public static DocumentModel.Drawings.LineSpacing? CreateModelElement(DXDraw.LineSpacing? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.LineSpacing();
      value.SpacingPercent = GetSpacingPercent(openXmlElement);
      value.SpacingPoints = GetSpacingPoints(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.LineSpacing? openXmlElement, DMDraws.LineSpacing? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSpacingPercent(openXmlElement, value.SpacingPercent, diffs, objName))
        ok = false;
      if (!CmpSpacingPoints(openXmlElement, value.SpacingPoints, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.LineSpacing value)
    where OpenXmlElementType: DXDraw.LineSpacing, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.LineSpacing openXmlElement, DMDraws.LineSpacing value)
  {
    SetSpacingPercent(openXmlElement, value?.SpacingPercent);
    SetSpacingPoints(openXmlElement, value?.SpacingPoints);
    }
  }
