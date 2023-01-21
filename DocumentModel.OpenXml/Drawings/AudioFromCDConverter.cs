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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.StartTime>();
    if (itemElement != null)
      return DMXDraws.AudioCDTimeTypeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.EndTime>();
    if (itemElement != null)
      return DMXDraws.AudioCDTimeTypeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      return DMXDraws.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMDraws.AudioFromCD? CreateModelElement(DXDraw.AudioFromCD? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.AudioFromCD();
      value.StartTime = GetStartTime(openXmlElement);
      value.EndTime = GetEndTime(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
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
