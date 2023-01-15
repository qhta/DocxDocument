using DocumentModel.Drawings.Charts;
using CatAxExtensionList = DocumentFormat.OpenXml.Drawing.Charts.CatAxExtensionList;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the CatAxExtensionList Class.
/// </summary>
public static class CatAxExtensionListConverter
{
  public static Collection<CatAxExtension>? GetCatAxExtensions(CatAxExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<CatAxExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.CatAxExtension>())
      {
        var newItem = CatAxExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetCatAxExtensions(CatAxExtensionList? openXmlElement, Collection<CatAxExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.CatAxExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = CatAxExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.CatAxExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Charts.CatAxExtensionList? CreateModelElement(CatAxExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.CatAxExtensionList();
      value.CatAxExtensions = GetCatAxExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.CatAxExtensionList? value)
    where OpenXmlElementType : CatAxExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCatAxExtensions(openXmlElement, value?.CatAxExtensions);
      return openXmlElement;
    }
    return default;
  }
}