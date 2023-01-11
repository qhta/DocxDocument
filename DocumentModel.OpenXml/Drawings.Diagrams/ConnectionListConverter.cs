namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Connection List.
/// </summary>
public static class ConnectionListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.Connection>? GetConnections(DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.Connection>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.Connection>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.Diagrams.ConnectionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetConnections(DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.Connection>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.Connection>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.Diagrams.ConnectionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Connection>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.ConnectionList? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionList? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionList, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
