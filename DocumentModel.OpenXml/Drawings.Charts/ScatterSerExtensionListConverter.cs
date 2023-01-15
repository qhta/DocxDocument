using DocumentModel.Drawings.Charts;
using ScatterSerExtensionList = DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtensionList;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the ScatterSerExtensionList Class.
/// </summary>
public static class ScatterSerExtensionListConverter
{
  public static Collection<ScatterSerExtension>? GetScatterSerExtensions(ScatterSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<ScatterSerExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtension>())
      {
        var newItem = ScatterSerExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetScatterSerExtensions(ScatterSerExtensionList? openXmlElement, Collection<ScatterSerExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = ScatterSerExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Charts.ScatterSerExtensionList? CreateModelElement(ScatterSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ScatterSerExtensionList();
      value.ScatterSerExtensions = GetScatterSerExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.ScatterSerExtensionList? value)
    where OpenXmlElementType : ScatterSerExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetScatterSerExtensions(openXmlElement, value?.ScatterSerExtensions);
      return openXmlElement;
    }
    return default;
  }
}