namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Single Formula.
/// </summary>
public static class FormulaConverter
{
  /// <summary>
  /// Equation
  /// </summary>
  private static String? GetEquation(DXV.Formula openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Equation);
  }
  
  private static bool CmpEquation(DXV.Formula openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Equation, value, diffs, objName, "Equation");
  }
  
  private static void SetEquation(DXV.Formula openXmlElement, String? value)
  {
    openXmlElement.Equation = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Vml.Formula? CreateModelElement(DXV.Formula? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Formula();
      value.Equation = GetEquation(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXV.Formula? openXmlElement, DMV.Formula? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEquation(openXmlElement, value.Equation, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMV.Formula value)
    where OpenXmlElementType: DXV.Formula, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXV.Formula openXmlElement, DMV.Formula value)
  {
    SetEquation(openXmlElement, value?.Equation);
  }
}
