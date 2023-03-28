namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Shape Guide converter from/to OpenXml.
///</summary>
public static class ShapeGuideConverter
{
  /// <summary>
  /// Shape Guide Name
  /// </summary>
  private static String? GetName(DXDraw.ShapeGuide openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Name);
  }
  
  private static bool CmpName(DXDraw.ShapeGuide openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Name, value, diffs, objName, "Name");
  }
  
  private static void SetName(DXDraw.ShapeGuide openXmlElement, String? value)
  {
    openXmlElement.Name = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shape Guide Formula
  /// </summary>
  private static String? GetFormula(DXDraw.ShapeGuide openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Formula);
  }
  
  private static bool CmpFormula(DXDraw.ShapeGuide openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Formula, value, diffs, objName, "Formula");
  }
  
  private static void SetFormula(DXDraw.ShapeGuide openXmlElement, String? value)
  {
    openXmlElement.Formula = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Drawings.ShapeGuide? CreateModelElement(DXDraw.ShapeGuide? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ShapeGuide();
      value.Name = GetName(openXmlElement);
      value.Formula = GetFormula(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.ShapeGuide? openXmlElement, DMDraws.ShapeGuide? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpName(openXmlElement, value.Name, diffs, objName))
        ok = false;
      if (!CmpFormula(openXmlElement, value.Formula, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ShapeGuide value)
    where OpenXmlElementType: DXDraw.ShapeGuide, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.ShapeGuide openXmlElement, DMDraws.ShapeGuide value)
  {
    SetName(openXmlElement, value?.Name);
    SetFormula(openXmlElement, value?.Formula);
  }
}
