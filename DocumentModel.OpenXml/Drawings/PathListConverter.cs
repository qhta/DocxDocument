using DocumentFormat.OpenXml.Drawing;
using Path = DocumentModel.Drawings.Path;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   List of Shape Paths.
/// </summary>
public static class PathListConverter
{
  public static Collection<Path>? GetPaths(PathList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<Path>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Path>())
      {
        var newItem = PathConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetPaths(PathList? openXmlElement, Collection<Path>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Path>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = PathConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Path>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.PathList? CreateModelElement(PathList? openXmlElement)
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
    where OpenXmlElementType : PathList, new()
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