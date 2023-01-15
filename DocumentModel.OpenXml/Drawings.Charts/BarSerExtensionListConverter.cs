using DocumentModel.Drawings.Charts;
using BarSerExtensionList = DocumentFormat.OpenXml.Drawing.Charts.BarSerExtensionList;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the BarSerExtensionList Class.
/// </summary>
public static class BarSerExtensionListConverter
{
  public static Collection<BarSerExtension>? GetBarSerExtensions(BarSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<BarSerExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.BarSerExtension>())
      {
        var newItem = BarSerExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetBarSerExtensions(BarSerExtensionList? openXmlElement, Collection<BarSerExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.BarSerExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = BarSerExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BarSerExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Charts.BarSerExtensionList? CreateModelElement(BarSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.BarSerExtensionList();
      value.BarSerExtensions = GetBarSerExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.BarSerExtensionList? value)
    where OpenXmlElementType : BarSerExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBarSerExtensions(openXmlElement, value?.BarSerExtensions);
      return openXmlElement;
    }
    return default;
  }
}