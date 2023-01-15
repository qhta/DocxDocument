using DocumentFormat.OpenXml.Vml;

namespace DocumentModel.OpenXml.Vml;

/// <summary>
///   Single Formula.
/// </summary>
public static class FormulaConverter
{
  /// <summary>
  ///   Equation
  /// </summary>
  public static String? GetEquation(Formula? openXmlElement)
  {
    return openXmlElement?.Equation?.Value;
  }

  public static void SetEquation(Formula? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Equation = new StringValue { Value = value };
      else
        openXmlElement.Equation = null;
  }

  public static DocumentModel.Vml.Formula? CreateModelElement(Formula? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Formula();
      value.Equation = GetEquation(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.Formula? value)
    where OpenXmlElementType : Formula, new()
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