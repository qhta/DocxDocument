namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the DataPoint Class.
/// </summary>
public static class DataPointConverter
{
  /// <summary>
  /// idx, this property is only available in Office 2016 and later.
  /// </summary>
  private static UInt32? GetIdx(DXO2016DrawChartDraw.DataPoint openXmlElement)
  {
    return openXmlElement.Idx?.Value;
  }
  
  private static void SetIdx(DXO2016DrawChartDraw.DataPoint openXmlElement, UInt32? value)
  {
    openXmlElement.Idx = value;
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  private static DMDrawsChartDraws.ShapeProperties? GetShapeProperties(DXO2016DrawChartDraw.DataPoint openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ShapeProperties>();
    if (itemElement != null)
      return DMXDrawsChartDraws.ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShapeProperties(DXO2016DrawChartDraw.DataPoint openXmlElement, DMDrawsChartDraws.ShapeProperties? value)
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
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDrawsChartDraws.ExtensionList? GetExtensionList(DXO2016DrawChartDraw.DataPoint openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsChartDraws.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXO2016DrawChartDraw.DataPoint openXmlElement, DMDrawsChartDraws.ExtensionList? value)
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
  
  public static DMDrawsChartDraws.DataPoint? CreateModelElement(DXO2016DrawChartDraw.DataPoint? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.DataPoint();
      value.Idx = GetIdx(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.DataPoint? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.DataPoint, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIdx(openXmlElement, value?.Idx);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
