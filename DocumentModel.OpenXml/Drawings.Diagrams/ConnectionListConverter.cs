namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Connection List.
/// </summary>
public static class ConnectionListConverter
{
  private static Collection<DMDrawsDgms.Connection> GetConnections(DXDrawDgms.ConnectionList openXmlElement)
  {
    var collection = new Collection<DMDrawsDgms.Connection>();
    foreach (var item in openXmlElement.Elements<DXDrawDgms.Connection>())
    {
      var newItem = DMXDrawsDgms.ConnectionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetConnections(DXDrawDgms.ConnectionList openXmlElement, Collection<DMDrawsDgms.Connection>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawDgms.Connection>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsDgms.ConnectionConverter.CreateOpenXmlElement<DXDrawDgms.Connection>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsDgms.ConnectionList? CreateModelElement(DXDrawDgms.ConnectionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.ConnectionList();
      value.Connections = GetConnections(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.ConnectionList? value)
    where OpenXmlElementType: DXDrawDgms.ConnectionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetConnections(openXmlElement, value?.Connections);
      return openXmlElement;
    }
    return default;
  }
}
