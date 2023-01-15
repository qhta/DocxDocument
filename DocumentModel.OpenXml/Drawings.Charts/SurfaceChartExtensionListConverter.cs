using DocumentModel.Drawings.Charts;
using SurfaceChartExtensionList = DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtensionList;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the SurfaceChartExtensionList Class.
/// </summary>
public static class SurfaceChartExtensionListConverter
{
  public static Collection<SurfaceChartExtension>? GetSurfaceChartExtensions(SurfaceChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<SurfaceChartExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtension>())
      {
        var newItem = SurfaceChartExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetSurfaceChartExtensions(SurfaceChartExtensionList? openXmlElement, Collection<SurfaceChartExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = SurfaceChartExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Charts.SurfaceChartExtensionList? CreateModelElement(SurfaceChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.SurfaceChartExtensionList();
      value.SurfaceChartExtensions = GetSurfaceChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.SurfaceChartExtensionList? value)
    where OpenXmlElementType : SurfaceChartExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSurfaceChartExtensions(openXmlElement, value?.SurfaceChartExtensions);
      return openXmlElement;
    }
    return default;
  }
}