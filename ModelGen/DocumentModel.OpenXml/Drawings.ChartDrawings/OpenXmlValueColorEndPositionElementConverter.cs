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
    return openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ExtremeValueColorPosition>() != null;
  }
  
  private static bool CmpExtremeValueColorPosition(DXO2016DrawChartDraw.OpenXmlValueColorEndPositionElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ExtremeValueColorPosition>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO2016DrawChartDraw.ExtremeValueColorPosition", val, value);
    return false;
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
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.NumberColorPosition>()?.Val);
  }
  
  private static bool CmpNumberColorPosition(DXO2016DrawChartDraw.OpenXmlValueColorEndPositionElement openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.NumberColorPosition>()?.Val, value, diffs, objName, "NumberColorPosition");
  }
  
  private static void SetNumberColorPosition(DXO2016DrawChartDraw.OpenXmlValueColorEndPositionElement openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXO2016DrawChartDraw.NumberColorPosition,System.Double>(openXmlElement, value);
  }
  
  /// <summary>
  /// PercentageColorPosition.
  /// </summary>
  private static Double? GetPercentageColorPosition(DXO2016DrawChartDraw.OpenXmlValueColorEndPositionElement openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.PercentageColorPosition>()?.Val);
  }
  
  private static bool CmpPercentageColorPosition(DXO2016DrawChartDraw.OpenXmlValueColorEndPositionElement openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.PercentageColorPosition>()?.Val, value, diffs, objName, "PercentageColorPosition");
  }
  
  private static void SetPercentageColorPosition(DXO2016DrawChartDraw.OpenXmlValueColorEndPositionElement openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXO2016DrawChartDraw.PercentageColorPosition,System.Double>(openXmlElement, value);
  }
  
  public static DocumentModel.Drawings.ChartDrawings.OpenXmlValueColorEndPositionElement? CreateModelElement(DXO2016DrawChartDraw.OpenXmlValueColorEndPositionElement? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.OpenXmlValueColorEndPositionElement();
      value.ExtremeValueColorPosition = GetExtremeValueColorPosition(openXmlElement);
      value.NumberColorPosition = GetNumberColorPosition(openXmlElement);
      value.PercentageColorPosition = GetPercentageColorPosition(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.OpenXmlValueColorEndPositionElement? openXmlElement, DMDrawsChartDraws.OpenXmlValueColorEndPositionElement? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.OpenXmlValueColorEndPositionElement value)
    where OpenXmlElementType: DXO2016DrawChartDraw.OpenXmlValueColorEndPositionElement, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.OpenXmlValueColorEndPositionElement openXmlElement, DMDrawsChartDraws.OpenXmlValueColorEndPositionElement value)
  {
    SetExtremeValueColorPosition(openXmlElement, value?.ExtremeValueColorPosition);
    SetNumberColorPosition(openXmlElement, value?.NumberColorPosition);
    SetPercentageColorPosition(openXmlElement, value?.PercentageColorPosition);
  }
}
