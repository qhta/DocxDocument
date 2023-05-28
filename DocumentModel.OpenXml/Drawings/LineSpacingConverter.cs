namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Line Spacing.
/// </summary>
public static class LineSpacingConverter
{
  private static Int32? GetSpacingPercent(DXD.LineSpacing openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXD.SpacingPercent>()?.Val);
  }
  
  private static bool CmpSpacingPercent(DXD.LineSpacing openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXD.SpacingPercent>()?.Val, value, diffs, objName, "SpacingPercent");
  }
  
  private static void SetSpacingPercent(DXD.LineSpacing openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXD.SpacingPercent,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetSpacingPoints(DXD.LineSpacing openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXD.SpacingPoints>()?.Val);
  }
  
  private static bool CmpSpacingPoints(DXD.LineSpacing openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXD.SpacingPoints>()?.Val, value, diffs, objName, "SpacingPoints");
  }
  
  private static void SetSpacingPoints(DXD.LineSpacing openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXD.SpacingPoints,System.Int32>(openXmlElement, value);
  }
  
  public static DMD.LineSpacing? CreateModelElement(DXD.LineSpacing? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.LineSpacing();
      value.SpacingPercent = GetSpacingPercent(openXmlElement);
      value.SpacingPoints = GetSpacingPoints(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.LineSpacing? openXmlElement, DMD.LineSpacing? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSpacingPercent(openXmlElement, value.SpacingPercent, diffs, objName, propName))
        ok = false;
      if (!CmpSpacingPoints(openXmlElement, value.SpacingPoints, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.LineSpacing value)
    where OpenXmlElementType: DXD.LineSpacing, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.LineSpacing openXmlElement, DMD.LineSpacing value)
  {
    SetSpacingPercent(openXmlElement, value?.SpacingPercent);
    SetSpacingPoints(openXmlElement, value?.SpacingPoints);
  }
}
