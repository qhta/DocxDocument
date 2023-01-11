namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// List of Shape Paths.
/// </summary>
public static class PathListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Path>? GetPaths(DocumentFormat.OpenXml.Drawing.PathList? openXmlElement)
  {
    if (openXmlElement != null)
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
    return null;
  }
  
  public static void SetPaths(DocumentFormat.OpenXml.Drawing.PathList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Path>? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
