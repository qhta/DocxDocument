using DocumentModel.Drawings.Diagrams;
using AdjustList = DocumentFormat.OpenXml.Drawing.Diagrams.AdjustList;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Shape Adjust List.
/// </summary>
public static class AdjustListConverter
{
  public static Collection<Adjust>? GetAdjusts(AdjustList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<Adjust>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.Adjust>())
      {
        var newItem = AdjustConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetAdjusts(AdjustList? openXmlElement, Collection<Adjust>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.Adjust>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = AdjustConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Adjust>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Diagrams.AdjustList? CreateModelElement(AdjustList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.AdjustList();
      value.Adjusts = GetAdjusts(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.AdjustList? value)
    where OpenXmlElementType : AdjustList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAdjusts(openXmlElement, value?.Adjusts);
      return openXmlElement;
    }
    return default;
  }
}