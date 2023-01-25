namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Single Formula.
/// </summary>
public static class FormulaConverter
{
  /// <summary>
  /// Equation
  /// </summary>
  private static String? GetEquation(DXVml.Formula openXmlElement)
  {
    return openXmlElement?.Equation?.Value;
  }
  
  private static bool CmpEquation(DXVml.Formula openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Equation?.Value == value;
  }
  
  private static void SetEquation(DXVml.Formula openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Equation = new StringValue { Value = value };
    else
      openXmlElement.Equation = null;
  }
  
  public static DMVml.Formula? CreateModelElement(DXVml.Formula? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMVml.Formula();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVml.Formula? value)
    where OpenXmlElementType: DXVml.Formula, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEquation(openXmlElement, value?.Equation);
      return openXmlElement;
    }
    return default;
  }
}
