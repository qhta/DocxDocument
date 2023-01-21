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
  
  private static void SetFormula(DXDraw.ShapeGuide openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Formula = new StringValue { Value = value };
    else
      openXmlElement.Formula = null;
  }
  
  public static DMDraws.ShapeGuide? CreateModelElement(DXDraw.ShapeGuide? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ShapeGuide();
      value.Name = GetName(openXmlElement);
      value.Formula = GetFormula(openXmlElement);
      return value;
    }
    return null;
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
