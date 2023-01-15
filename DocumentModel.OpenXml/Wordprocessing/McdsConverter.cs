using DocumentModel.Wordprocessing;
using Mcds = DocumentFormat.OpenXml.Office.Word.Mcds;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the Mcds Class.
/// </summary>
public static class McdsConverter
{
  public static Collection<Mcd>? GetItems(Mcds? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<Mcd>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office.Word.Mcd>())
      {
        var newItem = McdConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetItems(Mcds? openXmlElement, Collection<Mcd>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.Word.Mcd>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = McdConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Word.Mcd>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Wordprocessing.Mcds? CreateModelElement(Mcds? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Mcds();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Mcds? value)
    where OpenXmlElementType : Mcds, new()
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