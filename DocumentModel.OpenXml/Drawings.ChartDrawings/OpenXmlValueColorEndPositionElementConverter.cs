namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the OpenXmlValueColorEndPositionElement Class.
/// </summary>
public static class OpenXmlValueColorEndPositionElementConverter
{
  /// <summary>
  /// ExtremeValueColorPosition.
  /// </summary>
  private static Boolean? GetExtremeValueColorPosition(DXO2016DrawChartDraw.OpenXmlValueColorEndPositionElement openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ExtremeValueColorPosition>();
    return itemElement != null;
  }
  
  private static void SetExtremeValueColorPosition(DXO2016DrawChartDraw.OpenXmlValueColorEndPositionElement openXmlElement, Boolean? value)
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
  
  /// <summary>
  /// NumberColorPosition.
  /// </summary>
  private static Double? GetNumberColorPosition(DXO2016DrawChartDraw.OpenXmlValueColorEndPositionElement openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.NumberColorPosition>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetNumberColorPosition(DXO2016DrawChartDraw.OpenXmlValueColorEndPositionElement openXmlElement, Double? value)
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
  
  /// <summary>
  /// PercentageColorPosition.
  /// </summary>
  private static Double? GetPercentageColorPosition(DXO2016DrawChartDraw.OpenXmlValueColorEndPositionElement openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.PercentageColorPosition>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetPercentageColorPosition(DXO2016DrawChartDraw.OpenXmlValueColorEndPositionElement openXmlElement, Double? value)
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
  
  public static DMDrawsChartDraws.OpenXmlValueColorEndPositionElement? CreateModelElement(DXO2016DrawChartDraw.OpenXmlValueColorEndPositionElement? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.OpenXmlValueColorEndPositionElement();
      value.ExtremeValueColorPosition = GetExtremeValueColorPosition(openXmlElement);
      value.NumberColorPosition = GetNumberColorPosition(openXmlElement);
      value.PercentageColorPosition = GetPercentageColorPosition(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.OpenXmlValueColorEndPositionElement? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.OpenXmlValueColorEndPositionElement, new()
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
