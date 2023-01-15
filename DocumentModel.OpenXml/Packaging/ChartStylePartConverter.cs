using DocumentFormat.OpenXml.Packaging;
using DocumentModel.Drawings.ChartsStyle;
using DocumentModel.OpenXml.Drawings.ChartsStyle;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines the ChartStylePart
/// </summary>
public static class ChartStylePartConverter
{
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public static ChartStyle? GetChartStyle(ChartStylePart? openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle rootElement)
      return ChartStyleConverter.CreateModelElement(rootElement);
    return null;
  }

  public static void SetChartStyle(ChartStylePart? openXmlElement, ChartStyle? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
        var rootElement = ChartStyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle>(value);
        if (rootElement != null)
          openXmlElement.ChartStyle = rootElement;
      }
  }

  public static String? GetContentType(ChartStylePart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }

  public static String? GetRelationshipType(ChartStylePart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }

  public static DocumentModel.Packaging.ChartStylePart? CreateModelElement(ChartStylePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.ChartStylePart();
      value.ChartStyle = GetChartStyle(openXmlElement);
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.ChartStylePart? value)
    where OpenXmlElementType : ChartStylePart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetChartStyle(openXmlElement, value?.ChartStyle);
      //SetContentType(openXmlElement, value?.ContentType);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}