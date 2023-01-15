using DocumentModel.Drawings.Charts;
using AreaSerExtensionList = DocumentFormat.OpenXml.Drawing.Charts.AreaSerExtensionList;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the AreaSerExtensionList Class.
/// </summary>
public static class AreaSerExtensionListConverter
{
  public static Collection<AreaSerExtension>? GetAreaSerExtensions(AreaSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<AreaSerExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.AreaSerExtension>())
      {
        var newItem = AreaSerExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetAreaSerExtensions(AreaSerExtensionList? openXmlElement, Collection<AreaSerExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.AreaSerExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = AreaSerExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.AreaSerExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Charts.AreaSerExtensionList? CreateModelElement(AreaSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.AreaSerExtensionList();
      value.AreaSerExtensions = GetAreaSerExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.AreaSerExtensionList? value)
    where OpenXmlElementType : AreaSerExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAreaSerExtensions(openXmlElement, value?.AreaSerExtensions);
      return openXmlElement;
    }
    return default;
  }
}