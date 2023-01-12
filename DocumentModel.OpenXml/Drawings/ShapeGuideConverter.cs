namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Shape Guide.
/// </summary>
public static class ShapeGuideConverter
{
  /// <summary>
  /// Shape Guide Name
  /// </summary>
  public static String? GetName(DocumentFormat.OpenXml.Drawing.ShapeGuide? openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  public static void SetName(DocumentFormat.OpenXml.Drawing.ShapeGuide? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Name = new StringValue { Value = value };
      else
        openXmlElement.Name = null;
  }
  
  /// <summary>
  /// Shape Guide Formula
  /// </summary>
  public static String? GetFormula(DocumentFormat.OpenXml.Drawing.ShapeGuide? openXmlElement)
  {
    return openXmlElement?.Formula?.Value;
  }
  
  public static void SetFormula(DocumentFormat.OpenXml.Drawing.ShapeGuide? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Formula = new StringValue { Value = value };
      else
        openXmlElement.Formula = null;
  }
  
  public static DocumentModel.Drawings.ShapeGuide? CreateModelElement(DocumentFormat.OpenXml.Drawing.ShapeGuide? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ShapeGuide? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ShapeGuide, new()
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
