namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// List of Shape Paths.
/// </summary>
public static class PathListConverter
{
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Path> GetPaths(DocumentFormat.OpenXml.Drawing.PathList openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Path>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Path>())
    {
      var newItem = DocumentModel.OpenXml.Drawings.PathConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetPaths(DocumentFormat.OpenXml.Drawing.PathList openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Path>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Path>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Drawings.PathConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Path>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.PathList? CreateModelElement(DocumentFormat.OpenXml.Drawing.PathList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.PathList();
      value.Paths = GetPaths(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.PathList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.PathList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPaths(openXmlElement, value?.Paths);
      return openXmlElement;
    }
    return default;
  }
}
