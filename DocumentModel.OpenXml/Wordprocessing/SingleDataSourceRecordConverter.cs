namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SingleDataSourceRecord Class converter from/to OpenXml.
///</summary>
public static class SingleDataSourceRecordConverter
{
  /// <summary>
  /// RecordIncluded.
  /// </summary>
  private static Boolean? GetRecordIncluded(DXOW.SingleDataSourceRecord openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXOW.RecordIncluded>() != null;
  }
  
  private static bool CmpRecordIncluded(DXOW.SingleDataSourceRecord openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXOW.RecordIncluded>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXOW.RecordIncluded", val, value);
    return false;
  }
  
  private static void SetRecordIncluded(DXOW.SingleDataSourceRecord openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXOW.RecordIncluded>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXOW.RecordIncluded();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// RecordHashCode.
  /// </summary>
  private static Int64? GetRecordHashCode(DXOW.SingleDataSourceRecord openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXOW.RecordHashCode>()?.Val);
  }
  
  private static bool CmpRecordHashCode(DXOW.SingleDataSourceRecord openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXOW.RecordHashCode>()?.Val, value, diffs, objName, "RecordHashCode");
  }
  
  private static void SetRecordHashCode(DXOW.SingleDataSourceRecord openXmlElement, Int64? value)
  {
    SimpleValueConverter.SetValue<DXOW.RecordHashCode,System.Int64>(openXmlElement, value);
  }
  
  public static DMW.SingleDataSourceRecord? CreateModelElement(DXOW.SingleDataSourceRecord? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.SingleDataSourceRecord();
      value.RecordIncluded = GetRecordIncluded(openXmlElement);
      value.RecordHashCode = GetRecordHashCode(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOW.SingleDataSourceRecord? openXmlElement, DMW.SingleDataSourceRecord? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRecordIncluded(openXmlElement, value.RecordIncluded, diffs, objName))
        ok = false;
      if (!CmpRecordHashCode(openXmlElement, value.RecordHashCode, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.SingleDataSourceRecord value)
    where OpenXmlElementType: DXOW.SingleDataSourceRecord, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOW.SingleDataSourceRecord openXmlElement, DMW.SingleDataSourceRecord value)
  {
    SetRecordIncluded(openXmlElement, value?.RecordIncluded);
    SetRecordHashCode(openXmlElement, value?.RecordHashCode);
  }
}
