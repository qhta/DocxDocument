namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the NumericLevel Class.
/// </summary>
public static class NumericLevelConverter
{
  /// <summary>
  /// ptCount, this property is only available in Office 2016 and later.
  /// </summary>
  private static UInt32? GetPtCount(DXO2016DrawChartDraw.NumericLevel openXmlElement)
  {
    return openXmlElement.PtCount?.Value;
  }
  
  private static void SetPtCount(DXO2016DrawChartDraw.NumericLevel openXmlElement, UInt32? value)
  {
    openXmlElement.PtCount = value;
  }
  
  /// <summary>
  /// formatCode, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetFormatCode(DXO2016DrawChartDraw.NumericLevel openXmlElement)
  {
    return openXmlElement?.FormatCode?.Value;
  }
  
  private static void SetFormatCode(DXO2016DrawChartDraw.NumericLevel openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.FormatCode = new StringValue { Value = value };
    else
      openXmlElement.FormatCode = null;
  }
  
  /// <summary>
  /// name, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetName(DXO2016DrawChartDraw.NumericLevel openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static void SetName(DXO2016DrawChartDraw.NumericLevel openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  private static Collection<DMDrawsChartDraws.NumericValue> GetNumericValues(DXO2016DrawChartDraw.NumericLevel openXmlElement)
  {
    var collection = new Collection<DMDrawsChartDraws.NumericValue>();
    foreach (var item in openXmlElement.Elements<DXO2016DrawChartDraw.NumericValue>())
    {
      var newItem = DMXDrawsChartDraws.NumericValueConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetNumericValues(DXO2016DrawChartDraw.NumericLevel openXmlElement, Collection<DMDrawsChartDraws.NumericValue>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2016DrawChartDraw.NumericValue>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsChartDraws.NumericValueConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.NumericValue>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsChartDraws.NumericLevel? CreateModelElement(DXO2016DrawChartDraw.NumericLevel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.NumericLevel();
      value.PtCount = GetPtCount(openXmlElement);
      value.FormatCode = GetFormatCode(openXmlElement);
      value.Name = GetName(openXmlElement);
      value.NumericValues = GetNumericValues(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.NumericLevel? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.NumericLevel, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPtCount(openXmlElement, value?.PtCount);
      SetFormatCode(openXmlElement, value?.FormatCode);
      SetName(openXmlElement, value?.Name);
      SetNumericValues(openXmlElement, value?.NumericValues);
      return openXmlElement;
    }
    return default;
  }
}
