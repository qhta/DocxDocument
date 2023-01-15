using DocumentModel.Drawings.Charts;
using BandFormats = DocumentFormat.OpenXml.Drawing.Charts.BandFormats;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Band Formats.
/// </summary>
public static class BandFormatsConverter
{
  public static Collection<BandFormat>? GetItems(BandFormats? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<BandFormat>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.BandFormat>())
      {
        var newItem = BandFormatConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetItems(BandFormats? openXmlElement, Collection<BandFormat>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.BandFormat>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = BandFormatConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BandFormat>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Charts.BandFormats? CreateModelElement(BandFormats? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.BandFormats();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.BandFormats? value)
    where OpenXmlElementType : BandFormats, new()
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