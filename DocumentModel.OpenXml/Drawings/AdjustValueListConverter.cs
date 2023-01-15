using DocumentModel.Drawings;
using AdjustValueList = DocumentFormat.OpenXml.Drawing.AdjustValueList;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   List of Shape Adjust Values.
/// </summary>
public static class AdjustValueListConverter
{
  public static Collection<ShapeGuide>? GetShapeGuides(AdjustValueList? openXmlElement)
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

  public static void SetShapeGuides(AdjustValueList? openXmlElement, Collection<ShapeGuide>? value)
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

  public static DocumentModel.Drawings.AdjustValueList? CreateModelElement(AdjustValueList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.AdjustValueList();
      value.ShapeGuides = GetShapeGuides(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.AdjustValueList? value)
    where OpenXmlElementType : AdjustValueList, new()
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