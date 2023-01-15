using DocumentModel.Drawings.Charts;
using NumberingFormat = DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the NumberingFormat Class.
/// </summary>
public static class NumberingFormat3Converter
{
  /// <summary>
  ///   Number Format Code
  /// </summary>
  public static String? GetFormatCode(NumberingFormat? openXmlElement)
  {
    return openXmlElement?.FormatCode?.Value;
  }

  public static void SetFormatCode(NumberingFormat? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.FormatCode = new StringValue { Value = value };
      else
        openXmlElement.FormatCode = null;
  }

  /// <summary>
  ///   Linked to Source
  /// </summary>
  public static Boolean? GetSourceLinked(NumberingFormat? openXmlElement)
  {
    return openXmlElement?.SourceLinked?.Value;
  }

  public static void SetSourceLinked(NumberingFormat? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.SourceLinked = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.SourceLinked = null;
  }

  public static NumberingFormat3? CreateModelElement(NumberingFormat? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new NumberingFormat3();
      value.FormatCode = GetFormatCode(openXmlElement);
      value.SourceLinked = GetSourceLinked(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(NumberingFormat3? value)
    where OpenXmlElementType : NumberingFormat, new()
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