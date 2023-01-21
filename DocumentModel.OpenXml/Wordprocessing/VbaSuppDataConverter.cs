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
    var itemElement = openXmlElement?.GetFirstChild<DXOW.DocEvents>();
    if (itemElement != null)
      return DMXW.DocEventsConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOW.Mcds>();
    if (itemElement != null)
      return DMXW.McdsConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.VbaSuppData? value)
    where OpenXmlElementType: DXOW.VbaSuppData, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDocEvents(openXmlElement, value?.DocEvents);
      SetMcds(openXmlElement, value?.Mcds);
      return openXmlElement;
    }
    return default;
  }
}
