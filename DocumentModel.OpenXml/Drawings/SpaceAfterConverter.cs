namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Space After converter from/to OpenXml.
///</summary>
public static class SpaceAfterConverter
{
  private static Int32? GetSpacingPercent(DXDraw.SpaceAfter openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.SpacingPercent>()?.Val);
  }
  
  private static bool CmpSpacingPercent(DXDraw.SpaceAfter openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.SpacingPercent>()?.Val, value, diffs, objName, "SpacingPercent");
  }
  
  private static void SetSpacingPercent(DXDraw.SpaceAfter openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.SpacingPercent,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetSpacingPoints(DXDraw.SpaceAfter openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.SpacingPoints>()?.Val);
  }
  
  private static bool CmpSpacingPoints(DXDraw.SpaceAfter openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.SpacingPoints>()?.Val, value, diffs, objName, "SpacingPoints");
  }
  
  private static void SetSpacingPoints(DXDraw.SpaceAfter openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.SpacingPoints,System.Int32>(openXmlElement, value);
  }
  
  public static DocumentModel.Drawings.SpaceAfter? CreateModelElement(DXDraw.SpaceAfter? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.SpaceAfter();
      value.SpacingPercent = GetSpacingPercent(openXmlElement);
      value.SpacingPoints = GetSpacingPoints(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.SpaceAfter? openXmlElement, DMDraws.SpaceAfter? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.SpaceAfter value)
    where OpenXmlElementType: DXDraw.SpaceAfter, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.SpaceAfter openXmlElement, DMDraws.SpaceAfter value)
  {
    SetSpacingPercent(openXmlElement, value?.SpacingPercent);
    SetSpacingPoints(openXmlElement, value?.SpacingPoints);
  }
}
