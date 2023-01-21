namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Defines the PtExtensionList Class.
/// </summary>
public static class PtExtensionListConverter
{
  private static Collection<DMDraws.PtExtension> GetPtExtensions(DXDrawDgms.PtExtensionList openXmlElement)
  {
    var collection = new Collection<DMDraws.PtExtension>();
    foreach (var item in openXmlElement.Elements<DXDraw.PtExtension>())
    {
      var newItem = DMXDraws.PtExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetPtExtensions(DXDrawDgms.PtExtensionList openXmlElement, Collection<DMDraws.PtExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDraw.PtExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDraws.PtExtensionConverter.CreateOpenXmlElement<DXDraw.PtExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsDgms.PtExtensionList? CreateModelElement(DXDrawDgms.PtExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.PtExtensionList();
      value.PtExtensions = GetPtExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.PtExtensionList? value)
    where OpenXmlElementType: DXDrawDgms.PtExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPtExtensions(openXmlElement, value?.PtExtensions);
      return openXmlElement;
    }
    return default;
  }
}
