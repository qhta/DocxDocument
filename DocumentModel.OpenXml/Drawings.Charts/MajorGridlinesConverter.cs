using DocumentModel.Drawings.Charts;
using MajorGridlines = DocumentFormat.OpenXml.Drawing.Charts.MajorGridlines;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Major Gridlines.
/// </summary>
public static class MajorGridlinesConverter
{
  public static ChartShapeProperties? GetChartShapeProperties(MajorGridlines? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
    if (itemElement != null)
      return ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetChartShapeProperties(MajorGridlines? openXmlElement, ChartShapeProperties? value)
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

  public static DocumentModel.Drawings.Charts.MajorGridlines? CreateModelElement(MajorGridlines? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.MajorGridlines();
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.MajorGridlines? value)
    where OpenXmlElementType : MajorGridlines, new()
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