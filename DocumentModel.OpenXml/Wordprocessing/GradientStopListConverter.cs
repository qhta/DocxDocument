using DocumentModel.Wordprocessing;
using GradientStopList = DocumentFormat.OpenXml.Office2010.Word.GradientStopList;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the GradientStopList Class.
/// </summary>
public static class GradientStopListConverter
{
  public static Collection<GradientStop>? GetGradientStops(GradientStopList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<GradientStop>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2010.Word.GradientStop>())
      {
        var newItem = GradientStopConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetGradientStops(GradientStopList? openXmlElement, Collection<GradientStop>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.Word.GradientStop>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = GradientStopConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.GradientStop>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Wordprocessing.GradientStopList? CreateModelElement(GradientStopList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.GradientStopList();
      value.GradientStops = GetGradientStops(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.GradientStopList? value)
    where OpenXmlElementType : GradientStopList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGradientStops(openXmlElement, value?.GradientStops);
      return openXmlElement;
    }
    return default;
  }
}