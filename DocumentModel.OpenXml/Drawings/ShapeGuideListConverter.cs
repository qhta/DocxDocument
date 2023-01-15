using DocumentModel.Drawings;
using ShapeGuideList = DocumentFormat.OpenXml.Drawing.ShapeGuideList;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   List of Shape Guides.
/// </summary>
public static class ShapeGuideListConverter
{
  public static Collection<ShapeGuide>? GetShapeGuides(ShapeGuideList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<ShapeGuide>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.ShapeGuide>())
      {
        var newItem = ShapeGuideConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetShapeGuides(ShapeGuideList? openXmlElement, Collection<ShapeGuide>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.ShapeGuide>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = ShapeGuideConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ShapeGuide>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.ShapeGuideList? CreateModelElement(ShapeGuideList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ShapeGuideList();
      value.ShapeGuides = GetShapeGuides(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ShapeGuideList? value)
    where OpenXmlElementType : ShapeGuideList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetShapeGuides(openXmlElement, value?.ShapeGuides);
      return openXmlElement;
    }
    return default;
  }
}