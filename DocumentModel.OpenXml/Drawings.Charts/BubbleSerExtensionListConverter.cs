namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the BubbleSerExtensionList Class.
/// </summary>
public static class BubbleSerExtensionListConverter
{
  private static Collection<DMDrawsCharts.BubbleSerExtension> GetBubbleSerExtensions(DXDrawCharts.BubbleSerExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.BubbleSerExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.BubbleSerExtension>())
    {
      var newItem = DMXDrawsCharts.BubbleSerExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpBubbleSerExtensions(DXDrawCharts.BubbleSerExtensionList openXmlElement, Collection<DMDrawsCharts.BubbleSerExtension>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetBubbleSerExtensions(DXDrawCharts.BubbleSerExtensionList openXmlElement, Collection<DMDrawsCharts.BubbleSerExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.BubbleSerExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.BubbleSerExtensionConverter.CreateOpenXmlElement<DXDrawCharts.BubbleSerExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsCharts.BubbleSerExtensionList? CreateModelElement(DXDrawCharts.BubbleSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.BubbleSerExtensionList();
      value.BubbleSerExtensions = GetBubbleSerExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.BubbleSerExtensionList? openXmlElement, DMDrawsCharts.BubbleSerExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBubbleSerExtensions(openXmlElement, value.BubbleSerExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.BubbleSerExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.BubbleSerExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBubbleSerExtensions(openXmlElement, value?.BubbleSerExtensions);
      return openXmlElement;
    }
    return default;
  }
}
