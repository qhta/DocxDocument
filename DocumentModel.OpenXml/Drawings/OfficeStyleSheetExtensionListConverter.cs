using DocumentModel.Drawings;
using OfficeStyleSheetExtensionList = DocumentFormat.OpenXml.Drawing.OfficeStyleSheetExtensionList;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the OfficeStyleSheetExtensionList Class.
/// </summary>
public static class OfficeStyleSheetExtensionListConverter
{
  public static Collection<OfficeStyleSheetExtension>? GetOfficeStyleSheetExtensions(OfficeStyleSheetExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<OfficeStyleSheetExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.OfficeStyleSheetExtension>())
      {
        var newItem = OfficeStyleSheetExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetOfficeStyleSheetExtensions(OfficeStyleSheetExtensionList? openXmlElement, Collection<OfficeStyleSheetExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.OfficeStyleSheetExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = OfficeStyleSheetExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.OfficeStyleSheetExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.OfficeStyleSheetExtensionList? CreateModelElement(OfficeStyleSheetExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.OfficeStyleSheetExtensionList();
      value.OfficeStyleSheetExtensions = GetOfficeStyleSheetExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.OfficeStyleSheetExtensionList? value)
    where OpenXmlElementType : OfficeStyleSheetExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetOfficeStyleSheetExtensions(openXmlElement, value?.OfficeStyleSheetExtensions);
      return openXmlElement;
    }
    return default;
  }
}