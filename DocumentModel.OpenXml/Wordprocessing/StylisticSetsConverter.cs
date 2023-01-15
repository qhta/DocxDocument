using DocumentModel.Wordprocessing;
using StylisticSets = DocumentFormat.OpenXml.Office2010.Word.StylisticSets;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the StylisticSets Class.
/// </summary>
public static class StylisticSetsConverter
{
  public static Collection<StyleSet>? GetStyleSets(StylisticSets? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<StyleSet>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2010.Word.StyleSet>())
      {
        var newItem = StyleSetConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetStyleSets(StylisticSets? openXmlElement, Collection<StyleSet>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.Word.StyleSet>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = StyleSetConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.StyleSet>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Wordprocessing.StylisticSets? CreateModelElement(StylisticSets? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.StylisticSets();
      value.StyleSets = GetStyleSets(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.StylisticSets? value)
    where OpenXmlElementType : StylisticSets, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetStyleSets(openXmlElement, value?.StyleSets);
      return openXmlElement;
    }
    return default;
  }
}