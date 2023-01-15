using DocumentModel.Drawings.Charts;
using SurfaceSerExtensionList = DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtensionList;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the SurfaceSerExtensionList Class.
/// </summary>
public static class SurfaceSerExtensionListConverter
{
  public static Collection<SurfaceSerExtension>? GetSurfaceSerExtensions(SurfaceSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<SurfaceSerExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtension>())
      {
        var newItem = SurfaceSerExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetSurfaceSerExtensions(SurfaceSerExtensionList? openXmlElement, Collection<SurfaceSerExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = SurfaceSerExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Charts.SurfaceSerExtensionList? CreateModelElement(SurfaceSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.SurfaceSerExtensionList();
      value.SurfaceSerExtensions = GetSurfaceSerExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.SurfaceSerExtensionList? value)
    where OpenXmlElementType : SurfaceSerExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSurfaceSerExtensions(openXmlElement, value?.SurfaceSerExtensions);
      return openXmlElement;
    }
    return default;
  }
}