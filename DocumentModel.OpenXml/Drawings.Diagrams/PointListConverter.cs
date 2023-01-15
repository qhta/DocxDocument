using DocumentModel.Drawings.Diagrams;
using PointList = DocumentFormat.OpenXml.Drawing.Diagrams.PointList;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Point List.
/// </summary>
public static class PointListConverter
{
  public static Collection<Point>? GetPoints(PointList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<Point>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.Point>())
      {
        var newItem = PointConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetPoints(PointList? openXmlElement, Collection<Point>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.Point>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = PointConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Point>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Diagrams.PointList? CreateModelElement(PointList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.PointList();
      value.Points = GetPoints(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.PointList? value)
    where OpenXmlElementType : PointList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPoints(openXmlElement, value?.Points);
      return openXmlElement;
    }
    return default;
  }
}