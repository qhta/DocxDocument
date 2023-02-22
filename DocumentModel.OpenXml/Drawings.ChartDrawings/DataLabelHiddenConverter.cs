namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the DataLabelHidden Class.
/// </summary>
public static class DataLabelHiddenConverter
{
  /// <summary>
  /// idx, this property is only available in Office 2016 and later.
  /// </summary>
  private static UInt32? GetIdx(DXO2016DrawChartDraw.DataLabelHidden openXmlElement)
  {
    return openXmlElement?.Idx?.Value;
  }
  
  private static bool CmpIdx(DXO2016DrawChartDraw.DataLabelHidden openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Idx?.Value == value) return true;
    diffs?.Add(objName, "Idx", openXmlElement?.Idx?.Value, value);
    return false;
  }
  
  private static void SetIdx(DXO2016DrawChartDraw.DataLabelHidden openXmlElement, UInt32? value)
  {
    openXmlElement.Idx = value;
  }
  
  public static DocumentModel.Drawings.ChartDrawings.DataLabelHidden? CreateModelElement(DXO2016DrawChartDraw.DataLabelHidden? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.DataLabelHidden();
      value.Idx = GetIdx(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.DataLabelHidden? openXmlElement, DMDrawsChartDraws.DataLabelHidden? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpIdx(openXmlElement, value.Idx, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.DataLabelHidden value)
    where OpenXmlElementType: DXO2016DrawChartDraw.DataLabelHidden, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.DataLabelHidden openXmlElement, DMDrawsChartDraws.DataLabelHidden value)
  {
    SetIdx(openXmlElement, value?.Idx);
    }
  }
