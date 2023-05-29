namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Audio from CD.
/// </summary>
public static class AudioFromCDConverter
{
  /// <summary>
  /// Audio Start Time.
  /// </summary>
  private static DMD.AudioCDTimeType? GetStartTime(DXD.AudioFromCD openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.StartTime>();
    if (element != null)
      return DMXD.AudioCDTimeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStartTime(DXD.AudioFromCD openXmlElement, DMD.AudioCDTimeType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.AudioCDTimeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.StartTime>(), value, diffs, objName, propName);
  }
  
  private static void SetStartTime(DXD.AudioFromCD openXmlElement, DMD.AudioCDTimeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.StartTime>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.AudioCDTimeTypeConverter.CreateOpenXmlElement<DXD.StartTime>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Audio End Time.
  /// </summary>
  private static DMD.AudioCDTimeType? GetEndTime(DXD.AudioFromCD openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.EndTime>();
    if (element != null)
      return DMXD.AudioCDTimeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEndTime(DXD.AudioFromCD openXmlElement, DMD.AudioCDTimeType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.AudioCDTimeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EndTime>(), value, diffs, objName, propName);
  }
  
  private static void SetEndTime(DXD.AudioFromCD openXmlElement, DMD.AudioCDTimeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.EndTime>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.AudioCDTimeTypeConverter.CreateOpenXmlElement<DXD.EndTime>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMD.ExtensionList? GetExtensionList(DXD.AudioFromCD openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ExtensionList>();
    if (element != null)
      return DMXD.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXD.AudioFromCD openXmlElement, DMD.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXD.AudioFromCD openXmlElement, DMD.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ExtensionListConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.AudioFromCD? CreateModelElement(DXD.AudioFromCD? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.AudioFromCD();
      value.StartTime = GetStartTime(openXmlElement);
      value.EndTime = GetEndTime(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.AudioFromCD? openXmlElement, DMD.AudioFromCD? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpStartTime(openXmlElement, value.StartTime, diffs, objName, propName))
        ok = false;
      if (!CmpEndTime(openXmlElement, value.EndTime, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.AudioFromCD value)
    where OpenXmlElementType: DXD.AudioFromCD, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.AudioFromCD openXmlElement, DMD.AudioFromCD value)
  {
    SetStartTime(openXmlElement, value?.StartTime);
    SetEndTime(openXmlElement, value?.EndTime);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
