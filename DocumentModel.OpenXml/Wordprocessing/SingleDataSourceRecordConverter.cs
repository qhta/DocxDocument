namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SingleDataSourceRecord Class.
/// </summary>
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
    return openXmlElement.GetFirstChild<DXOW.RecordIncluded>() != null == value;
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
    return openXmlElement?.GetFirstChild<DXOW.RecordHashCode>()?.Val?.Value;
  }
  
  private static bool CmpRecordHashCode(DXOW.SingleDataSourceRecord openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXOW.RecordHashCode>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXOW.RecordHashCode", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetRecordHashCode(DXOW.SingleDataSourceRecord openXmlElement, Int64? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOW.RecordHashCode>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXOW.RecordHashCode{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.SingleDataSourceRecord? value)
    where OpenXmlElementType: DXOW.SingleDataSourceRecord, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRecordIncluded(openXmlElement, value?.RecordIncluded);
      SetRecordHashCode(openXmlElement, value?.RecordHashCode);
      return openXmlElement;
    }
    return default;
  }
}
