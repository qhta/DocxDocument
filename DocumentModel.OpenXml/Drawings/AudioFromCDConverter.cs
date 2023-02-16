namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Audio from CD.
/// </summary>
public static class AudioFromCDConverter
{
  /// <summary>
  /// Audio Start Time.
  /// </summary>
  private static DMDraws.AudioCDTimeType? GetStartTime(DXDraw.AudioFromCD openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.StartTime>();
    if (element != null)
      return DMXDraws.AudioCDTimeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStartTime(DXDraw.AudioFromCD openXmlElement, DMDraws.AudioCDTimeType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.AudioCDTimeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.StartTime>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetStartTime(DXDraw.AudioFromCD openXmlElement, DMDraws.AudioCDTimeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.StartTime>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.AudioCDTimeTypeConverter.CreateOpenXmlElement<DXDraw.StartTime>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Audio End Time.
  /// </summary>
  private static DMDraws.AudioCDTimeType? GetEndTime(DXDraw.AudioFromCD openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.EndTime>();
    if (element != null)
      return DMXDraws.AudioCDTimeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEndTime(DXDraw.AudioFromCD openXmlElement, DMDraws.AudioCDTimeType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.AudioCDTimeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.EndTime>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEndTime(DXDraw.AudioFromCD openXmlElement, DMDraws.AudioCDTimeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.EndTime>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.AudioCDTimeTypeConverter.CreateOpenXmlElement<DXDraw.EndTime>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDraws.ExtensionList? GetExtensionList(DXDraw.AudioFromCD openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.ExtensionList>();
    if (element != null)
      return DMXDraws.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDraw.AudioFromCD openXmlElement, DMDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXDraw.AudioFromCD openXmlElement, DMDraws.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ExtensionListConverter.CreateOpenXmlElement<DXDraw.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.AudioFromCD? CreateModelElement(DXDraw.AudioFromCD? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.AudioFromCD();
      value.StartTime = GetStartTime(openXmlElement);
      value.EndTime = GetEndTime(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.AudioFromCD? openXmlElement, DMDraws.AudioFromCD? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpStartTime(openXmlElement, value.StartTime, diffs, objName))
        ok = false;
      if (!CmpEndTime(openXmlElement, value.EndTime, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.AudioFromCD? value)
    where OpenXmlElementType: DXDraw.AudioFromCD, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetStartTime(openXmlElement, value?.StartTime);
      SetEndTime(openXmlElement, value?.EndTime);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
