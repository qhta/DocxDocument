using DocumentModel.Drawings;
using BlipExtensionList = DocumentFormat.OpenXml.Drawing.BlipExtensionList;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Future extensions..
/// </summary>
public static class BlipExtensionListConverter
{
  public static Collection<BlipExtension>? GetBlipExtensions(BlipExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<BlipExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.BlipExtension>())
      {
        var newItem = BlipExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetBlipExtensions(BlipExtensionList? openXmlElement, Collection<BlipExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.BlipExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = BlipExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.BlipExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.BlipExtensionList? CreateModelElement(BlipExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.BlipExtensionList();
      value.BlipExtensions = GetBlipExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.BlipExtensionList? value)
    where OpenXmlElementType : BlipExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBlipExtensions(openXmlElement, value?.BlipExtensions);
      return openXmlElement;
    }
    return default;
  }
}