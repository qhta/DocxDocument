using DocumentModel.Drawings;
using ConnectionSiteList = DocumentFormat.OpenXml.Drawing.ConnectionSiteList;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   List of Shape Connection Sites.
/// </summary>
public static class ConnectionSiteListConverter
{
  public static Collection<ConnectionSite>? GetConnectionSites(ConnectionSiteList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<ConnectionSite>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.ConnectionSite>())
      {
        var newItem = ConnectionSiteConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetConnectionSites(ConnectionSiteList? openXmlElement, Collection<ConnectionSite>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.ConnectionSite>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = ConnectionSiteConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ConnectionSite>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.ConnectionSiteList? CreateModelElement(ConnectionSiteList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ConnectionSiteList();
      value.ConnectionSites = GetConnectionSites(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ConnectionSiteList? value)
    where OpenXmlElementType : ConnectionSiteList, new()
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