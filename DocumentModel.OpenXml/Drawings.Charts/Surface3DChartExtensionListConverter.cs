using DocumentModel.Drawings.Charts;
using Surface3DChartExtensionList = DocumentFormat.OpenXml.Drawing.Charts.Surface3DChartExtensionList;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the Surface3DChartExtensionList Class.
/// </summary>
public static class Surface3DChartExtensionListConverter
{
  public static Collection<Surface3DChartExtension>? GetSurface3DChartExtensions(Surface3DChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<Surface3DChartExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.Surface3DChartExtension>())
      {
        var newItem = Surface3DChartExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetSurface3DChartExtensions(Surface3DChartExtensionList? openXmlElement, Collection<Surface3DChartExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.Surface3DChartExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = Surface3DChartExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Surface3DChartExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Charts.Surface3DChartExtensionList? CreateModelElement(Surface3DChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Surface3DChartExtensionList();
      value.Surface3DChartExtensions = GetSurface3DChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.Surface3DChartExtensionList? value)
    where OpenXmlElementType : Surface3DChartExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSurface3DChartExtensions(openXmlElement, value?.Surface3DChartExtensions);
      return openXmlElement;
    }
    return default;
  }
}