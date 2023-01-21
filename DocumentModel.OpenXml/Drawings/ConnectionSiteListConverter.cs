namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// List of Shape Connection Sites.
/// </summary>
public static class ConnectionSiteListConverter
{
  private static Collection<DMDraws.ConnectionSite> GetConnectionSites(DXDraw.ConnectionSiteList openXmlElement)
  {
    var collection = new Collection<DMDraws.ConnectionSite>();
    foreach (var item in openXmlElement.Elements<DXDraw.ConnectionSite>())
    {
      var newItem = DMXDraws.ConnectionSiteConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetConnectionSites(DXDraw.ConnectionSiteList openXmlElement, Collection<DMDraws.ConnectionSite>? value)
  {
    openXmlElement.RemoveAllChildren<DXDraw.ConnectionSite>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDraws.ConnectionSiteConverter.CreateOpenXmlElement<DXDraw.ConnectionSite>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDraws.ConnectionSiteList? CreateModelElement(DXDraw.ConnectionSiteList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ConnectionSiteList();
      value.ConnectionSites = GetConnectionSites(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ConnectionSiteList? value)
    where OpenXmlElementType: DXDraw.ConnectionSiteList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetConnectionSites(openXmlElement, value?.ConnectionSites);
      return openXmlElement;
    }
    return default;
  }
}
