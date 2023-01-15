using DocumentModel.Drawings.Charts;
using PivotFormats = DocumentFormat.OpenXml.Drawing.Charts.PivotFormats;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   pivot chart format persistence data.
/// </summary>
public static class PivotFormatsConverter
{
  public static Collection<PivotFormat>? GetItems(PivotFormats? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<PivotFormat>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.PivotFormat>())
      {
        var newItem = PivotFormatConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetItems(PivotFormats? openXmlElement, Collection<PivotFormat>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.PivotFormat>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = PivotFormatConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.PivotFormat>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Charts.PivotFormats? CreateModelElement(PivotFormats? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.PivotFormats();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.PivotFormats? value)
    where OpenXmlElementType : PivotFormats, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetItems(openXmlElement, value?.Items);
      return openXmlElement;
    }
    return default;
  }
}