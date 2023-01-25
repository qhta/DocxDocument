namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the MaxValueColorEndPosition Class.
/// </summary>
public static class MaxValueColorEndPositionConverter
{
  private static Boolean? GetExtremeValueColorPosition(DXO2016DrawChartDraw.MaxValueColorEndPosition openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ExtremeValueColorPosition>() != null;
  }
  
  private static bool CmpExtremeValueColorPosition(DXO2016DrawChartDraw.MaxValueColorEndPosition openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ExtremeValueColorPosition>() != null == value;
  }
  
  private static void SetExtremeValueColorPosition(DXO2016DrawChartDraw.MaxValueColorEndPosition openXmlElement, Boolean? value)
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
  
  private static Double? GetNumberColorPosition(DXO2016DrawChartDraw.MaxValueColorEndPosition openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.NumberColorPosition>()?.Val?.Value;
  }
  
  private static bool CmpNumberColorPosition(DXO2016DrawChartDraw.MaxValueColorEndPosition openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.NumberColorPosition>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXO2016DrawChartDraw.NumberColorPosition", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetNumberColorPosition(DXO2016DrawChartDraw.MaxValueColorEndPosition openXmlElement, Double? value)
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
  
  private static Double? GetPercentageColorPosition(DXO2016DrawChartDraw.MaxValueColorEndPosition openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.PercentageColorPosition>()?.Val?.Value;
  }
  
  private static bool CmpPercentageColorPosition(DXO2016DrawChartDraw.MaxValueColorEndPosition openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.PercentageColorPosition>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXO2016DrawChartDraw.PercentageColorPosition", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetPercentageColorPosition(DXO2016DrawChartDraw.MaxValueColorEndPosition openXmlElement, Double? value)
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
  
  public static DMDrawsChartDraws.MaxValueColorEndPosition? CreateModelElement(DXO2016DrawChartDraw.MaxValueColorEndPosition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.MaxValueColorEndPosition();
      value.ExtremeValueColorPosition = GetExtremeValueColorPosition(openXmlElement);
      value.NumberColorPosition = GetNumberColorPosition(openXmlElement);
      value.PercentageColorPosition = GetPercentageColorPosition(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.MaxValueColorEndPosition? openXmlElement, DMDrawsChartDraws.MaxValueColorEndPosition? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpExtremeValueColorPosition(openXmlElement, value.ExtremeValueColorPosition, diffs, objName))
        ok = false;
      if (!CmpNumberColorPosition(openXmlElement, value.NumberColorPosition, diffs, objName))
        ok = false;
      if (!CmpPercentageColorPosition(openXmlElement, value.PercentageColorPosition, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.MaxValueColorEndPosition? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.MaxValueColorEndPosition, new()
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
