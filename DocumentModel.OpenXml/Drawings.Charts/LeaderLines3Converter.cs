using DocumentModel.Drawings.Charts;
using LeaderLines = DocumentFormat.OpenXml.Office2013.Drawing.Chart.LeaderLines;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the LeaderLines Class.
/// </summary>
public static class LeaderLines3Converter
{
  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  public static ChartShapeProperties? GetChartShapeProperties(LeaderLines? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
    if (itemElement != null)
      return ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetChartShapeProperties(LeaderLines? openXmlElement, ChartShapeProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ChartShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static LeaderLines3? CreateModelElement(LeaderLines? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new LeaderLines3();
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(LeaderLines3? value)
    where OpenXmlElementType : LeaderLines, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
      return openXmlElement;
    }
    return default;
  }
}