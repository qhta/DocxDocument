using DocumentModel.Drawings.Charts;
using BubbleSerExtensionList = DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtensionList;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the BubbleSerExtensionList Class.
/// </summary>
public static class BubbleSerExtensionListConverter
{
  public static Collection<BubbleSerExtension>? GetBubbleSerExtensions(BubbleSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<BubbleSerExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtension>())
      {
        var newItem = BubbleSerExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetBubbleSerExtensions(BubbleSerExtensionList? openXmlElement, Collection<BubbleSerExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = BubbleSerExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Charts.BubbleSerExtensionList? CreateModelElement(BubbleSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.BubbleSerExtensionList();
      value.BubbleSerExtensions = GetBubbleSerExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.BubbleSerExtensionList? value)
    where OpenXmlElementType : BubbleSerExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBubbleSerExtensions(openXmlElement, value?.BubbleSerExtensions);
      return openXmlElement;
    }
    return default;
  }
}