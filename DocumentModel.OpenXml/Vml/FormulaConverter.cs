namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Single Formula converter from/to OpenXml.
///</summary>
public static class FormulaConverter
{
  /// <summary>
  /// Equation
  /// </summary>
  private static String? GetEquation(DXVml.Formula openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Equation);
  }
  
  private static bool CmpEquation(DXVml.Formula openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Equation, value, diffs, objName, "Equation");
  }
  
  private static void SetEquation(DXVml.Formula openXmlElement, String? value)
  {
    openXmlElement.Equation = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Vml.Formula? CreateModelElement(DXVml.Formula? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Formula();
      value.Equation = GetEquation(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXVml.Formula? openXmlElement, DMVml.Formula? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEquation(openXmlElement, value.Equation, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMVml.Formula value)
    where OpenXmlElementType: DXVml.Formula, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVml.Formula openXmlElement, DMVml.Formula value)
  {
    SetEquation(openXmlElement, value?.Equation);
  }
}
