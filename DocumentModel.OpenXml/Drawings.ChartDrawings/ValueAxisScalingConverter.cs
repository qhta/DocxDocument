using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the ValueAxisScaling Class.
/// </summary>
public static class ValueAxisScalingConverter
{
  /// <summary>
  ///   max, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetMax(ValueAxisScaling? openXmlElement)
  {
    return openXmlElement?.Max?.Value;
  }

  public static void SetMax(ValueAxisScaling? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Max = new StringValue { Value = value };
      else
        openXmlElement.Max = null;
  }

  /// <summary>
  ///   min, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetMin(ValueAxisScaling? openXmlElement)
  {
    return openXmlElement?.Min?.Value;
  }

  public static void SetMin(ValueAxisScaling? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Min = new StringValue { Value = value };
      else
        openXmlElement.Min = null;
  }

  /// <summary>
  ///   majorUnit, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetMajorUnit(ValueAxisScaling? openXmlElement)
  {
    return openXmlElement?.MajorUnit?.Value;
  }

  public static void SetMajorUnit(ValueAxisScaling? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.MajorUnit = new StringValue { Value = value };
      else
        openXmlElement.MajorUnit = null;
  }

  /// <summary>
  ///   minorUnit, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetMinorUnit(ValueAxisScaling? openXmlElement)
  {
    return openXmlElement?.MinorUnit?.Value;
  }

  public static void SetMinorUnit(ValueAxisScaling? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.MinorUnit = new StringValue { Value = value };
      else
        openXmlElement.MinorUnit = null;
  }

  public static DocumentModel.Drawings.ChartDrawings.ValueAxisScaling? CreateModelElement(ValueAxisScaling? openXmlElement)
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
    where OpenXmlElementType : ValueAxisScaling, new()
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