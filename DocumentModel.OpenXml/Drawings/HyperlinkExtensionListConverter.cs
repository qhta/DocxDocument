using DocumentModel.Drawings;
using HyperlinkExtensionList = DocumentFormat.OpenXml.Drawing.HyperlinkExtensionList;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Future extensions..
/// </summary>
public static class HyperlinkExtensionListConverter
{
  public static Collection<HyperlinkExtension>? GetHyperlinkExtensions(HyperlinkExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<HyperlinkExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.HyperlinkExtension>())
      {
        var newItem = HyperlinkExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetHyperlinkExtensions(HyperlinkExtensionList? openXmlElement, Collection<HyperlinkExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.HyperlinkExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = HyperlinkExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.HyperlinkExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.HyperlinkExtensionList? CreateModelElement(HyperlinkExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.HyperlinkExtensionList();
      value.HyperlinkExtensions = GetHyperlinkExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.HyperlinkExtensionList? value)
    where OpenXmlElementType : HyperlinkExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetHyperlinkExtensions(openXmlElement, value?.HyperlinkExtensions);
      return openXmlElement;
    }
    return default;
  }
}