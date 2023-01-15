using DocumentModel.Drawings.Charts;
using DLblExtensionList = DocumentFormat.OpenXml.Drawing.Charts.DLblExtensionList;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the DLblExtensionList Class.
/// </summary>
public static class DLblExtensionListConverter
{
  public static Collection<DLblExtension>? GetDLblExtensions(DLblExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<DLblExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.DLblExtension>())
      {
        var newItem = DLblExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetDLblExtensions(DLblExtensionList? openXmlElement, Collection<DLblExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.DLblExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = DLblExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DLblExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Charts.DLblExtensionList? CreateModelElement(DLblExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DLblExtensionList();
      value.DLblExtensions = GetDLblExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.DLblExtensionList? value)
    where OpenXmlElementType : DLblExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDLblExtensions(openXmlElement, value?.DLblExtensions);
      return openXmlElement;
    }
    return default;
  }
}