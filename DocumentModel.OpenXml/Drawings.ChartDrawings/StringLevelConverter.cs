namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the StringLevel Class.
/// </summary>
public static class StringLevelConverter
{
  /// <summary>
  /// ptCount, this property is only available in Office 2016 and later.
  /// </summary>
  private static UInt32? GetPtCount(DXO2016DrawChartDraw.StringLevel openXmlElement)
  {
    return openXmlElement.PtCount?.Value;
  }
  
  private static void SetPtCount(DXO2016DrawChartDraw.StringLevel openXmlElement, UInt32? value)
  {
    openXmlElement.PtCount = value;
  }
  
  /// <summary>
  /// name, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetName(DXO2016DrawChartDraw.StringLevel openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static void SetName(DXO2016DrawChartDraw.StringLevel openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  private static Collection<DMDrawsChartDraws.ChartStringValue> GetChartStringValues(DXO2016DrawChartDraw.StringLevel openXmlElement)
  {
    var collection = new Collection<DMDrawsChartDraws.ChartStringValue>();
    foreach (var item in openXmlElement.Elements<DXO2016DrawChartDraw.ChartStringValue>())
    {
      var newItem = DMXDrawsChartDraws.ChartStringValueConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetChartStringValues(DXO2016DrawChartDraw.StringLevel openXmlElement, Collection<DMDrawsChartDraws.ChartStringValue>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2016DrawChartDraw.ChartStringValue>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsChartDraws.ChartStringValueConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.ChartStringValue>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsChartDraws.StringLevel? CreateModelElement(DXO2016DrawChartDraw.StringLevel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.StringLevel();
      value.PtCount = GetPtCount(openXmlElement);
      value.Name = GetName(openXmlElement);
      value.ChartStringValues = GetChartStringValues(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.StringLevel? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.StringLevel, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPtCount(openXmlElement, value?.PtCount);
      SetName(openXmlElement, value?.Name);
      SetChartStringValues(openXmlElement, value?.ChartStringValues);
      return openXmlElement;
    }
    return default;
  }
}
