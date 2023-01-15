using DocumentModel.Drawings.ChartDrawings;
using Statistics = DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Statistics;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the Statistics Class.
/// </summary>
public static class StatisticsConverter
{
  /// <summary>
  ///   quartileMethod, this property is only available in Office 2016 and later.
  /// </summary>
  public static QuartileMethod? GetQuartileMethod(Statistics? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.QuartileMethod, QuartileMethod>(openXmlElement?.QuartileMethod?.Value);
  }

  public static void SetQuartileMethod(Statistics? openXmlElement, QuartileMethod? value)
  {
    if (openXmlElement != null)
      openXmlElement.QuartileMethod = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.QuartileMethod, QuartileMethod>(value);
  }

  public static DocumentModel.Drawings.ChartDrawings.Statistics? CreateModelElement(Statistics? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.Statistics();
      value.QuartileMethod = GetQuartileMethod(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.Statistics? value)
    where OpenXmlElementType : Statistics, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetQuartileMethod(openXmlElement, value?.QuartileMethod);
      return openXmlElement;
    }
    return default;
  }
}