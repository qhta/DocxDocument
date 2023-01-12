namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// List of Shape Connection Sites.
/// </summary>
public static class ConnectionSiteListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ConnectionSite>? GetConnectionSites(DocumentFormat.OpenXml.Drawing.ConnectionSiteList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ConnectionSite>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.ConnectionSite>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.ConnectionSiteConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetConnectionSites(DocumentFormat.OpenXml.Drawing.ConnectionSiteList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ConnectionSite>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.ConnectionSite>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.ConnectionSiteConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ConnectionSite>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.ConnectionSiteList? CreateModelElement(DocumentFormat.OpenXml.Drawing.ConnectionSiteList? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ConnectionSiteList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
