namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Level.
/// </summary>
public static class LevelConverter
{
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.StringPoint> GetStringPoints(DocumentFormat.OpenXml.Drawing.Charts.Level openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.StringPoint>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.StringPoint>())
    {
      var newItem = DocumentModel.OpenXml.Drawings.Charts.StringPointConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetStringPoints(DocumentFormat.OpenXml.Drawing.Charts.Level openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.StringPoint>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.StringPoint>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.StringPointConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.StringPoint>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.Level? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.Level? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Level();
      value.StringPoints = GetStringPoints(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.Level? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.Level, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetStringPoints(openXmlElement, value?.StringPoints);
      return openXmlElement;
    }
    return default;
  }
}
