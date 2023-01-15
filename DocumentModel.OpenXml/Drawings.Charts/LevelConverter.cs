using DocumentModel.Drawings.Charts;
using Level = DocumentFormat.OpenXml.Drawing.Charts.Level;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Level.
/// </summary>
public static class LevelConverter
{
  public static Collection<StringPoint>? GetStringPoints(Level? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<StringPoint>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.StringPoint>())
      {
        var newItem = StringPointConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetStringPoints(Level? openXmlElement, Collection<StringPoint>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.StringPoint>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = StringPointConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.StringPoint>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Charts.Level? CreateModelElement(Level? openXmlElement)
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
    where OpenXmlElementType : Level, new()
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