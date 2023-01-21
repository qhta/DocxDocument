namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ChartData Class.
/// </summary>
public static class ChartDataConverter
{
  /// <summary>
  /// ExternalData.
  /// </summary>
  private static DMDrawsChartDraws.ExternalData? GetExternalData(DXO2016DrawChartDraw.ChartData openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ExternalData>();
    if (itemElement != null)
      return DMXDrawsChartDraws.ExternalDataConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExternalData(DXO2016DrawChartDraw.ChartData openXmlElement, DMDrawsChartDraws.ExternalData? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ExternalData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.ExternalDataConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.ExternalData>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartDraws.Data? GetData(DXO2016DrawChartDraw.ChartData openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.Data>();
    if (itemElement != null)
      return DMXDrawsChartDraws.DataConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetData(DXO2016DrawChartDraw.ChartData openXmlElement, DMDrawsChartDraws.Data? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.Data>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.DataConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.Data>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartDraws.ExtensionList? GetExtensionList(DXO2016DrawChartDraw.ChartData openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsChartDraws.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXO2016DrawChartDraw.ChartData openXmlElement, DMDrawsChartDraws.ExtensionList? value)
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
  
  public static DMDrawsChartDraws.ChartData? CreateModelElement(DXO2016DrawChartDraw.ChartData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.ChartData();
      value.ExternalData = GetExternalData(openXmlElement);
      value.Data = GetData(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.ChartData? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.ChartData, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExternalData(openXmlElement, value?.ExternalData);
      SetData(openXmlElement, value?.Data);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
