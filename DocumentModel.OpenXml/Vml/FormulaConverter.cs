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
