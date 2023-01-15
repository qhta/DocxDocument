using DocumentModel.Drawings.Charts;
using DLblsExtensionList = DocumentFormat.OpenXml.Drawing.Charts.DLblsExtensionList;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the DLblsExtensionList Class.
/// </summary>
public static class DLblsExtensionListConverter
{
  public static Collection<DLblsExtension>? GetDLblsExtensions(DLblsExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<DLblsExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.DLblsExtension>())
      {
        var newItem = DLblsExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetDLblsExtensions(DLblsExtensionList? openXmlElement, Collection<DLblsExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.DLblsExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = DLblsExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DLblsExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Charts.DLblsExtensionList? CreateModelElement(DLblsExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DLblsExtensionList();
      value.DLblsExtensions = GetDLblsExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.DLblsExtensionList? value)
    where OpenXmlElementType : DLblsExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDLblsExtensions(openXmlElement, value?.DLblsExtensions);
      return openXmlElement;
    }
    return default;
  }
}