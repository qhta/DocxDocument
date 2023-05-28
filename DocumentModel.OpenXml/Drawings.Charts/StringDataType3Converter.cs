namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the StringDataType Class.
/// </summary>
public static class StringDataType3Converter
{
  /// <summary>
  /// PointCount.
  /// </summary>
  private static UInt32? GetPointCount(DXO13DC.StringDataType openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.PointCount>()?.Val);
  }
  
  private static bool CmpPointCount(DXO13DC.StringDataType openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.PointCount>()?.Val, value, diffs, objName, "PointCount");
  }
  
  private static void SetPointCount(DXO13DC.StringDataType openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDC.PointCount,System.UInt32>(openXmlElement, value);
  }
  
  public static DMD.Charts.StringDataType3? CreateModelElement(DXO13DC.StringDataType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.StringDataType3();
      value.PointCount = GetPointCount(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO13DC.StringDataType? openXmlElement, DMDC.StringDataType3? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPointCount(openXmlElement, value.PointCount, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.StringDataType3 value)
    where OpenXmlElementType: DXO13DC.StringDataType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13DC.StringDataType openXmlElement, DMDC.StringDataType3 value)
  {
    SetPointCount(openXmlElement, value?.PointCount);
  }
}
