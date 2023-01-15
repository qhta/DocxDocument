using DocumentModel.Drawings.Charts;
using StrDataExtensionList = DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the StrDataExtensionList Class.
/// </summary>
public static class StrDataExtensionListConverter
{
  public static Collection<StrDataExtension>? GetStrDataExtensions(StrDataExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<StrDataExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.StrDataExtension>())
      {
        var newItem = StrDataExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetStrDataExtensions(StrDataExtensionList? openXmlElement, Collection<StrDataExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.StrDataExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = StrDataExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.StrDataExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Charts.StrDataExtensionList? CreateModelElement(StrDataExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.StrDataExtensionList();
      value.StrDataExtensions = GetStrDataExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.StrDataExtensionList? value)
    where OpenXmlElementType : StrDataExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetStrDataExtensions(openXmlElement, value?.StrDataExtensions);
      return openXmlElement;
    }
    return default;
  }
}