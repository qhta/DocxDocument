using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the NumberFormat Class.
/// </summary>
public static class NumberFormatConverter
{
  /// <summary>
  ///   formatCode, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetFormatCode(NumberFormat? openXmlElement)
  {
    return openXmlElement?.FormatCode?.Value;
  }

  public static void SetFormatCode(NumberFormat? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.FormatCode = new StringValue { Value = value };
      else
        openXmlElement.FormatCode = null;
  }

  /// <summary>
  ///   sourceLinked, this property is only available in Office 2016 and later.
  /// </summary>
  public static Boolean? GetSourceLinked(NumberFormat? openXmlElement)
  {
    return openXmlElement?.SourceLinked?.Value;
  }

  public static void SetSourceLinked(NumberFormat? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.SourceLinked = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.SourceLinked = null;
  }

  public static DocumentModel.Drawings.ChartDrawings.NumberFormat? CreateModelElement(NumberFormat? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.NumberFormat();
      value.FormatCode = GetFormatCode(openXmlElement);
      value.SourceLinked = GetSourceLinked(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.NumberFormat? value)
    where OpenXmlElementType : NumberFormat, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFormatCode(openXmlElement, value?.FormatCode);
      SetSourceLinked(openXmlElement, value?.SourceLinked);
      return openXmlElement;
    }
    return default;
  }
}