using DocumentModel.Drawings;
using TabStopList = DocumentFormat.OpenXml.Drawing.TabStopList;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Tab List.
/// </summary>
public static class TabStopListConverter
{
  public static Collection<TabStop>? GetTabStops(TabStopList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<TabStop>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.TabStop>())
      {
        var newItem = TabStopConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetTabStops(TabStopList? openXmlElement, Collection<TabStop>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.TabStop>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = TabStopConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.TabStop>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.TabStopList? CreateModelElement(TabStopList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.TabStopList();
      value.TabStops = GetTabStops(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.TabStopList? value)
    where OpenXmlElementType : TabStopList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTabStops(openXmlElement, value?.TabStops);
      return openXmlElement;
    }
    return default;
  }
}