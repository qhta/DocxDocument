namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the CategoryAxisScaling Class.
/// </summary>
public static class CategoryAxisScalingConverter
{
  /// <summary>
  /// gapWidth, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetGapWidth(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.CategoryAxisScaling? openXmlElement)
  {
    return openXmlElement?.GapWidth?.Value;
  }
  
  public static void SetGapWidth(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.CategoryAxisScaling? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GapWidth = new StringValue { Value = value };
      else
        openXmlElement.GapWidth = null;
  }
  
  public static DocumentModel.Drawings.ChartDrawings.CategoryAxisScaling? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.CategoryAxisScaling? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.CategoryAxisScaling();
      value.GapWidth = GetGapWidth(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.CategoryAxisScaling? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.CategoryAxisScaling, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGapWidth(openXmlElement, value?.GapWidth);
      return openXmlElement;
    }
    return default;
  }
}
