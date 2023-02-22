namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the MinValueColorEndPosition Class.
/// </summary>
public static class MinValueColorEndPositionConverter
{
  private static Boolean? GetExtremeValueColorPosition(DXO2016DrawChartDraw.MinValueColorEndPosition openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ExtremeValueColorPosition>() != null;
  }
  
  private static bool CmpExtremeValueColorPosition(DXO2016DrawChartDraw.MinValueColorEndPosition openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ExtremeValueColorPosition>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO2016DrawChartDraw.ExtremeValueColorPosition", val, value);
    return false;
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
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.NumberColorPosition>()?.Val);
  }
  
  private static bool CmpNumberColorPosition(DXO2016DrawChartDraw.MinValueColorEndPosition openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.NumberColorPosition>()?.Val, value, diffs, objName, "NumberColorPosition");
  }
  
  private static void SetNumberColorPosition(DXO2016DrawChartDraw.MinValueColorEndPosition openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXO2016DrawChartDraw.NumberColorPosition,System.Double>(openXmlElement, value);
  }
  
  private static Double? GetPercentageColorPosition(DXO2016DrawChartDraw.MinValueColorEndPosition openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.PercentageColorPosition>()?.Val);
  }
  
  private static bool CmpPercentageColorPosition(DXO2016DrawChartDraw.MinValueColorEndPosition openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.PercentageColorPosition>()?.Val, value, diffs, objName, "PercentageColorPosition");
  }
  
  private static void SetPercentageColorPosition(DXO2016DrawChartDraw.MinValueColorEndPosition openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXO2016DrawChartDraw.PercentageColorPosition,System.Double>(openXmlElement, value);
  }
  
  public static DocumentModel.Drawings.ChartDrawings.MinValueColorEndPosition? CreateModelElement(DXO2016DrawChartDraw.MinValueColorEndPosition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.MinValueColorEndPosition();
      value.ExtremeValueColorPosition = GetExtremeValueColorPosition(openXmlElement);
      value.NumberColorPosition = GetNumberColorPosition(openXmlElement);
      value.PercentageColorPosition = GetPercentageColorPosition(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.MinValueColorEndPosition? openXmlElement, DMDrawsChartDraws.MinValueColorEndPosition? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.MinValueColorEndPosition value)
    where OpenXmlElementType: DXO2016DrawChartDraw.MinValueColorEndPosition, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.MinValueColorEndPosition openXmlElement, DMDrawsChartDraws.MinValueColorEndPosition value)
  {
    SetExtremeValueColorPosition(openXmlElement, value?.ExtremeValueColorPosition);
    SetNumberColorPosition(openXmlElement, value?.NumberColorPosition);
    SetPercentageColorPosition(openXmlElement, value?.PercentageColorPosition);
  }
}
