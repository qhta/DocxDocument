using DocumentModel.Drawings.Diagrams;
using ConnectionList = DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionList;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Connection List.
/// </summary>
public static class ConnectionListConverter
{
  public static Collection<Connection>? GetConnections(ConnectionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<Connection>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.Connection>())
      {
        var newItem = ConnectionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetConnections(ConnectionList? openXmlElement, Collection<Connection>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.Connection>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = ConnectionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Connection>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Diagrams.ConnectionList? CreateModelElement(ConnectionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.ConnectionList();
      value.Connections = GetConnections(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.ConnectionList? value)
    where OpenXmlElementType : ConnectionList, new()
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