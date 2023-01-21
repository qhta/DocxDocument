namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Data Class.
/// </summary>
public static class DataConverter
{
  /// <summary>
  /// id, this property is only available in Office 2016 and later.
  /// </summary>
  private static UInt32? GetId(DXO2016DrawChartDraw.Data openXmlElement)
  {
    return openXmlElement.Id?.Value;
  }
  
  private static void SetId(DXO2016DrawChartDraw.Data openXmlElement, UInt32? value)
  {
    openXmlElement.Id = value;
  }
  
  private static DMDrawsChartDraws.NumericDimension? GetNumericDimension(DXO2016DrawChartDraw.Data openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.NumericDimension>();
    if (itemElement != null)
      return DMXDrawsChartDraws.NumericDimensionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNumericDimension(DXO2016DrawChartDraw.Data openXmlElement, DMDrawsChartDraws.NumericDimension? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.NumericDimension>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.NumericDimensionConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.NumericDimension>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartDraws.StringDimension? GetStringDimension(DXO2016DrawChartDraw.Data openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.StringDimension>();
    if (itemElement != null)
      return DMXDrawsChartDraws.StringDimensionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStringDimension(DXO2016DrawChartDraw.Data openXmlElement, DMDrawsChartDraws.StringDimension? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.StringDimension>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.StringDimensionConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.StringDimension>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartDraws.ExtensionList? GetExtensionList(DXO2016DrawChartDraw.Data openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsChartDraws.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXO2016DrawChartDraw.Data openXmlElement, DMDrawsChartDraws.ExtensionList? value)
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
  
  public static DMDrawsChartDraws.Data? CreateModelElement(DXO2016DrawChartDraw.Data? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.Data();
      value.Id = GetId(openXmlElement);
      value.NumericDimension = GetNumericDimension(openXmlElement);
      value.StringDimension = GetStringDimension(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.Data? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.Data, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetNumericDimension(openXmlElement, value?.NumericDimension);
      SetStringDimension(openXmlElement, value?.StringDimension);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
