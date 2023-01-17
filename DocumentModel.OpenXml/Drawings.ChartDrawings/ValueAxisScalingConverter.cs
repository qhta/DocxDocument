namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ValueAxisScaling Class.
/// </summary>
public static class ValueAxisScalingConverter
{
  /// <summary>
  /// max, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetMax(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueAxisScaling openXmlElement)
  {
    return openXmlElement?.Max?.Value;
  }
  
  private static void SetMax(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueAxisScaling openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Max = new StringValue { Value = value };
    else
      openXmlElement.Max = null;
  }
  
  /// <summary>
  /// min, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetMin(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueAxisScaling openXmlElement)
  {
    return openXmlElement?.Min?.Value;
  }
  
  private static void SetMin(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueAxisScaling openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Min = new StringValue { Value = value };
    else
      openXmlElement.Min = null;
  }
  
  /// <summary>
  /// majorUnit, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetMajorUnit(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueAxisScaling openXmlElement)
  {
    return openXmlElement?.MajorUnit?.Value;
  }
  
  private static void SetMajorUnit(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueAxisScaling openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.MajorUnit = new StringValue { Value = value };
    else
      openXmlElement.MajorUnit = null;
  }
  
  /// <summary>
  /// minorUnit, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetMinorUnit(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueAxisScaling openXmlElement)
  {
    return openXmlElement?.MinorUnit?.Value;
  }
  
  private static void SetMinorUnit(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueAxisScaling openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.MinorUnit = new StringValue { Value = value };
    else
      openXmlElement.MinorUnit = null;
  }
  
  public static DocumentModel.Drawings.ChartDrawings.ValueAxisScaling? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueAxisScaling? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.ValueAxisScaling();
      value.Max = GetMax(openXmlElement);
      value.Min = GetMin(openXmlElement);
      value.MajorUnit = GetMajorUnit(openXmlElement);
      value.MinorUnit = GetMinorUnit(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.ValueAxisScaling? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueAxisScaling, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMax(openXmlElement, value?.Max);
      SetMin(openXmlElement, value?.Min);
      SetMajorUnit(openXmlElement, value?.MajorUnit);
      SetMinorUnit(openXmlElement, value?.MinorUnit);
      return openXmlElement;
    }
    return default;
  }
}
