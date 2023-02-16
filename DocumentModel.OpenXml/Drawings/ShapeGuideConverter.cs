namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Shape Guide.
/// </summary>
public static class ShapeGuideConverter
{
  /// <summary>
  /// Shape Guide Name
  /// </summary>
  private static String? GetName(DXDraw.ShapeGuide openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static bool CmpName(DXDraw.ShapeGuide openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Name?.Value == value) return true;
    diffs?.Add(objName, "Name", openXmlElement?.Name?.Value, value);
    return false;
  }
  
  private static void SetName(DXDraw.ShapeGuide openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// Shape Guide Formula
  /// </summary>
  private static String? GetFormula(DXDraw.ShapeGuide openXmlElement)
  {
    return openXmlElement?.Formula?.Value;
  }
  
  private static bool CmpFormula(DXDraw.ShapeGuide openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Formula?.Value == value) return true;
    diffs?.Add(objName, "Formula", openXmlElement?.Formula?.Value, value);
    return false;
  }
  
  private static void SetFormula(DXDraw.ShapeGuide openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Formula = new StringValue { Value = value };
    else
      openXmlElement.Formula = null;
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ShapeGuide? value)
    where OpenXmlElementType: DXDraw.ShapeGuide, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetFormula(openXmlElement, value?.Formula);
      return openXmlElement;
    }
    return default;
  }
}
