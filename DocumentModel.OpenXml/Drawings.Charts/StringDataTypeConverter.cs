namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the StringDataType Class.
/// </summary>
public static class StringDataTypeConverter
{
  /// <summary>
  /// PointCount.
  /// </summary>
  private static UInt32? GetPointCount(DXDC.StringDataType openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.PointCount>()?.Val);
  }
  
  private static bool CmpPointCount(DXDC.StringDataType openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.PointCount>()?.Val, value, diffs, objName, "PointCount");
  }
  
  private static void SetPointCount(DXDC.StringDataType openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDC.PointCount,System.UInt32>(openXmlElement, value);
  }
  
  public static DocumentModel.Drawings.Charts.StringDataType? CreateModelElement(DXDC.StringDataType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.StringDataType();
      value.PointCount = GetPointCount(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.StringDataType? openXmlElement, DMDC.StringDataType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPointCount(openXmlElement, value.PointCount, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.StringDataType value)
    where OpenXmlElementType: DXDC.StringDataType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.StringDataType openXmlElement, DMDC.StringDataType value)
  {
    SetPointCount(openXmlElement, value?.PointCount);
  }
}
