namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the MinValueColorEndPosition Class.
/// </summary>
public static class MinValueColorEndPositionConverter
{
  private static Boolean? GetExtremeValueColorPosition(DXO2016DrawChartDraw.MinValueColorEndPosition openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ExtremeValueColorPosition>();
    return itemElement != null;
  }
  
  private static void SetExtremeValueColorPosition(DXO2016DrawChartDraw.MinValueColorEndPosition openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ExtremeValueColorPosition>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2016DrawChartDraw.ExtremeValueColorPosition();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Double? GetNumberColorPosition(DXO2016DrawChartDraw.MinValueColorEndPosition openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.NumberColorPosition>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetNumberColorPosition(DXO2016DrawChartDraw.MinValueColorEndPosition openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.NumberColorPosition>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2016DrawChartDraw.NumberColorPosition{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Double? GetPercentageColorPosition(DXO2016DrawChartDraw.MinValueColorEndPosition openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.PercentageColorPosition>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetPercentageColorPosition(DXO2016DrawChartDraw.MinValueColorEndPosition openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.PercentageColorPosition>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2016DrawChartDraw.PercentageColorPosition{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsChartDraws.MinValueColorEndPosition? CreateModelElement(DXO2016DrawChartDraw.MinValueColorEndPosition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.MinValueColorEndPosition();
      value.ExtremeValueColorPosition = GetExtremeValueColorPosition(openXmlElement);
      value.NumberColorPosition = GetNumberColorPosition(openXmlElement);
      value.PercentageColorPosition = GetPercentageColorPosition(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.MinValueColorEndPosition? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.MinValueColorEndPosition, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtremeValueColorPosition(openXmlElement, value?.ExtremeValueColorPosition);
      SetNumberColorPosition(openXmlElement, value?.NumberColorPosition);
      SetPercentageColorPosition(openXmlElement, value?.PercentageColorPosition);
      return openXmlElement;
    }
    return default;
  }
}
