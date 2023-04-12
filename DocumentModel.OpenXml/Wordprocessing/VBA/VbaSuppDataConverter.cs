namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the VbaSuppData Class.
/// </summary>
public static class VbaSuppDataConverter
{
  /// <summary>
  /// DocEvents.
  /// </summary>
  private static DMW.DocEvents? GetDocEvents(DXOW.VbaSuppData openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOW.DocEvents>();
    if (element != null)
      return DMXW.DocEventsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDocEvents(DXOW.VbaSuppData openXmlElement, DMW.DocEvents? value, DiffList? diffs, string? objName)
  {
    return DMXW.DocEventsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOW.DocEvents>(), value, diffs, objName);
  }
  
  private static void SetDocEvents(DXOW.VbaSuppData openXmlElement, DMW.DocEvents? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOW.DocEvents>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.DocEventsConverter.CreateOpenXmlElement<DXOW.DocEvents>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Mcds.
  /// </summary>
  private static DMW.Mcds? GetMcds(DXOW.VbaSuppData openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOW.Mcds>();
    if (element != null)
      return DMXW.McdsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMcds(DXOW.VbaSuppData openXmlElement, DMW.Mcds? value, DiffList? diffs, string? objName)
  {
    return DMXW.McdsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOW.Mcds>(), value, diffs, objName);
  }
  
  private static void SetMcds(DXOW.VbaSuppData openXmlElement, DMW.Mcds? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOW.Mcds>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.McdsConverter.CreateOpenXmlElement<DXOW.Mcds>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.VbaSuppData? CreateModelElement(DXOW.VbaSuppData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.VbaSuppData();
      value.DocEvents = GetDocEvents(openXmlElement);
      value.Mcds = GetMcds(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOW.VbaSuppData? openXmlElement, DMW.VbaSuppData? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDocEvents(openXmlElement, value.DocEvents, diffs, objName))
        ok = false;
      if (!CmpMcds(openXmlElement, value.Mcds, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.VbaSuppData value)
    where OpenXmlElementType: DXOW.VbaSuppData, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOW.VbaSuppData openXmlElement, DMW.VbaSuppData value)
  {
    SetDocEvents(openXmlElement, value?.DocEvents);
    SetMcds(openXmlElement, value?.Mcds);
  }
}
