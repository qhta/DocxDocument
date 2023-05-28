namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Shape Guide.
/// </summary>
public static class ShapeGuideConverter
{
  /// <summary>
  /// Shape Guide Name
  /// </summary>
  private static String? GetName(DXD.ShapeGuide openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Name);
  }
  
  private static bool CmpName(DXD.ShapeGuide openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Name, value, diffs, objName, "Name");
  }
  
  private static void SetName(DXD.ShapeGuide openXmlElement, String? value)
  {
    openXmlElement.Name = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shape Guide Formula
  /// </summary>
  private static String? GetFormula(DXD.ShapeGuide openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Formula);
  }
  
  private static bool CmpFormula(DXD.ShapeGuide openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Formula, value, diffs, objName, "Formula");
  }
  
  private static void SetFormula(DXD.ShapeGuide openXmlElement, String? value)
  {
    openXmlElement.Formula = StringValueConverter.CreateStringValue(value);
  }
  
  public static DMD.ShapeGuide? CreateModelElement(DXD.ShapeGuide? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.ShapeGuide();
      value.Name = GetName(openXmlElement);
      value.Formula = GetFormula(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.ShapeGuide? openXmlElement, DMD.ShapeGuide? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpName(openXmlElement, value.Name, diffs, objName, propName))
        ok = false;
      if (!CmpFormula(openXmlElement, value.Formula, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.ShapeGuide value)
    where OpenXmlElementType: DXD.ShapeGuide, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.ShapeGuide openXmlElement, DMD.ShapeGuide value)
  {
    SetName(openXmlElement, value?.Name);
    SetFormula(openXmlElement, value?.Formula);
  }
}
