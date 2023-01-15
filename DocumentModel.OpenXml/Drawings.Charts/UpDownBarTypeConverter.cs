using DocumentModel.Drawings.Charts;
using UpDownBarType = DocumentFormat.OpenXml.Drawing.Charts.UpDownBarType;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the UpDownBarType Class.
/// </summary>
public static class UpDownBarTypeConverter
{
  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  public static ChartShapeProperties? GetChartShapeProperties(UpDownBarType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
    if (itemElement != null)
      return ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetChartShapeProperties(UpDownBarType? openXmlElement, ChartShapeProperties? value)
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

  public static DocumentModel.Drawings.Charts.UpDownBarType? CreateModelElement(UpDownBarType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.UpDownBarType();
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.UpDownBarType? value)
    where OpenXmlElementType : UpDownBarType, new()
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