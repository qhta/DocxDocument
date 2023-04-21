namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the MaxValueColorEndPosition Class.
/// </summary>
public static class MaxValueColorEndPositionConverter
{
  private static Boolean? GetExtremeValueColorPosition(DXO16DCD.MaxValueColorEndPosition openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO16DCD.ExtremeValueColorPosition>() != null;
  }
  
  private static bool CmpExtremeValueColorPosition(DXO16DCD.MaxValueColorEndPosition openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXO16DCD.ExtremeValueColorPosition>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO16DCD.ExtremeValueColorPosition", val, value);
    return false;
  }
  
  private static void SetExtremeValueColorPosition(DXO16DCD.MaxValueColorEndPosition openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO16DCD.ExtremeValueColorPosition>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO16DCD.ExtremeValueColorPosition();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Double? GetNumberColorPosition(DXO16DCD.MaxValueColorEndPosition openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO16DCD.NumberColorPosition>()?.Val);
  }
  
  private static bool CmpNumberColorPosition(DXO16DCD.MaxValueColorEndPosition openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO16DCD.NumberColorPosition>()?.Val, value, diffs, objName, "NumberColorPosition");
  }
  
  private static void SetNumberColorPosition(DXO16DCD.MaxValueColorEndPosition openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXO16DCD.NumberColorPosition,System.Double>(openXmlElement, value);
  }
  
  private static Double? GetPercentageColorPosition(DXO16DCD.MaxValueColorEndPosition openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO16DCD.PercentageColorPosition>()?.Val);
  }
  
  private static bool CmpPercentageColorPosition(DXO16DCD.MaxValueColorEndPosition openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO16DCD.PercentageColorPosition>()?.Val, value, diffs, objName, "PercentageColorPosition");
  }
  
  private static void SetPercentageColorPosition(DXO16DCD.MaxValueColorEndPosition openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXO16DCD.PercentageColorPosition,System.Double>(openXmlElement, value);
  }
  
  public static DocumentModel.Drawings.ChartDrawings.MaxValueColorEndPosition? CreateModelElement(DXO16DCD.MaxValueColorEndPosition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.MaxValueColorEndPosition();
      value.ExtremeValueColorPosition = GetExtremeValueColorPosition(openXmlElement);
      value.NumberColorPosition = GetNumberColorPosition(openXmlElement);
      value.PercentageColorPosition = GetPercentageColorPosition(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.MaxValueColorEndPosition? openXmlElement, DMDCDs.MaxValueColorEndPosition? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.MaxValueColorEndPosition value)
    where OpenXmlElementType: DXO16DCD.MaxValueColorEndPosition, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.MaxValueColorEndPosition openXmlElement, DMDCDs.MaxValueColorEndPosition value)
  {
    SetExtremeValueColorPosition(openXmlElement, value?.ExtremeValueColorPosition);
    SetNumberColorPosition(openXmlElement, value?.NumberColorPosition);
    SetPercentageColorPosition(openXmlElement, value?.PercentageColorPosition);
  }
}
