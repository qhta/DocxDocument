namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Point List.
/// </summary>
public static class PointListConverter
{
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.Point> GetPoints(DocumentFormat.OpenXml.Drawing.Diagrams.PointList openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.Point>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.Point>())
    {
      var newItem = DocumentModel.OpenXml.Drawings.Diagrams.PointConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetPoints(DocumentFormat.OpenXml.Drawing.Diagrams.PointList openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.Point>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.Point>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Drawings.Diagrams.PointConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Point>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.PointList? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.PointList? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.PointList, new()
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
