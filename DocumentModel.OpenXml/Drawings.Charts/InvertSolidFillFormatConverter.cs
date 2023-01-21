namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the InvertSolidFillFormat Class.
/// </summary>
public static class InvertSolidFillFormatConverter
{
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  private static DMDrawsCharts.ShapeProperties2? GetShapeProperties(DXO2010DrawCharts.InvertSolidFillFormat openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010DrawCharts.ShapeProperties>();
    if (itemElement != null)
      return DMXDrawsCharts.ShapeProperties2Converter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShapeProperties(DXO2010DrawCharts.InvertSolidFillFormat openXmlElement, DMDrawsCharts.ShapeProperties2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010DrawCharts.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ShapeProperties2Converter.CreateOpenXmlElement<DXO2010DrawCharts.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.InvertSolidFillFormat? CreateModelElement(DXO2010DrawCharts.InvertSolidFillFormat? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.InvertSolidFillFormat();
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.InvertSolidFillFormat? value)
    where OpenXmlElementType: DXO2010DrawCharts.InvertSolidFillFormat, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      return openXmlElement;
    }
    return default;
  }
}
