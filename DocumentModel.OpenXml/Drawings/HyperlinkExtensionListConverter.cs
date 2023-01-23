namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Future extensions..
/// </summary>
public static class HyperlinkExtensionListConverter
{
  private static Collection<DMDraws.HyperlinkExtension> GetHyperlinkExtensions(DXDraw.HyperlinkExtensionList openXmlElement)
  {
    var collection = new Collection<DMDraws.HyperlinkExtension>();
    foreach (var item in openXmlElement.Elements<DXDraw.HyperlinkExtension>())
    {
      var newItem = DMXDraws.HyperlinkExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpHyperlinkExtensions(DXDraw.HyperlinkExtensionList openXmlElement, Collection<DMDraws.HyperlinkExtension>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetHyperlinkExtensions(DXDraw.HyperlinkExtensionList openXmlElement, Collection<DMDraws.HyperlinkExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDraw.HyperlinkExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDraws.HyperlinkExtensionConverter.CreateOpenXmlElement<DXDraw.HyperlinkExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDraws.HyperlinkExtensionList? CreateModelElement(DXDraw.HyperlinkExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.HyperlinkExtensionList();
      value.HyperlinkExtensions = GetHyperlinkExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.HyperlinkExtensionList? openXmlElement, DMDraws.HyperlinkExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpHyperlinkExtensions(openXmlElement, value.HyperlinkExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.HyperlinkExtensionList? value)
    where OpenXmlElementType: DXDraw.HyperlinkExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetHyperlinkExtensions(openXmlElement, value?.HyperlinkExtensions);
      return openXmlElement;
    }
    return default;
  }
}
