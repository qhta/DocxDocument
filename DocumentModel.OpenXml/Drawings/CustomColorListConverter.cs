using DocumentModel.Drawings;
using CustomColorList = DocumentFormat.OpenXml.Drawing.CustomColorList;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the CustomColorList Class.
/// </summary>
public static class CustomColorListConverter
{
  public static Collection<CustomColor>? GetCustomColors(CustomColorList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<CustomColor>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.CustomColor>())
      {
        var newItem = CustomColorConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetCustomColors(CustomColorList? openXmlElement, Collection<CustomColor>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.CustomColor>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = CustomColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.CustomColor>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.CustomColorList? CreateModelElement(CustomColorList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.CustomColorList();
      value.CustomColors = GetCustomColors(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.CustomColorList? value)
    where OpenXmlElementType : CustomColorList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCustomColors(openXmlElement, value?.CustomColors);
      return openXmlElement;
    }
    return default;
  }
}