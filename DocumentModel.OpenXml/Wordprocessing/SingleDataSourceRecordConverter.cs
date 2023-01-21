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
    var itemElement = openXmlElement.GetFirstChild<DXOW.RecordIncluded>();
    return itemElement != null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOW.RecordHashCode>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
