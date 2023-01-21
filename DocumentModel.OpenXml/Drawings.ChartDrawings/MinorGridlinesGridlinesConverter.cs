namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the MinorGridlinesGridlines Class.
/// </summary>
public static class MinorGridlinesGridlinesConverter
{
  private static DMDrawsChartDraws.ShapeProperties? GetShapeProperties(DXO2016DrawChartDraw.MinorGridlinesGridlines openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ShapeProperties>();
    if (itemElement != null)
      return DMXDrawsChartDraws.ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShapeProperties(DXO2016DrawChartDraw.MinorGridlinesGridlines openXmlElement, DMDrawsChartDraws.ShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.ShapePropertiesConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartDraws.ExtensionList? GetExtensionList(DXO2016DrawChartDraw.MinorGridlinesGridlines openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsChartDraws.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXO2016DrawChartDraw.MinorGridlinesGridlines openXmlElement, DMDrawsChartDraws.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.ExtensionListConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsChartDraws.MinorGridlinesGridlines? CreateModelElement(DXO2016DrawChartDraw.MinorGridlinesGridlines? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.MinorGridlinesGridlines();
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.MinorGridlinesGridlines? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.MinorGridlinesGridlines, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
