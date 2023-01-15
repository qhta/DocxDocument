using DocumentModel.Drawings.Charts;
using ScatterChartExtensionList = DocumentFormat.OpenXml.Drawing.Charts.ScatterChartExtensionList;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the ScatterChartExtensionList Class.
/// </summary>
public static class ScatterChartExtensionListConverter
{
  public static Collection<ScatterChartExtension>? GetScatterChartExtensions(ScatterChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<ScatterChartExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.ScatterChartExtension>())
      {
        var newItem = ScatterChartExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetScatterChartExtensions(ScatterChartExtensionList? openXmlElement, Collection<ScatterChartExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.ScatterChartExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = ScatterChartExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ScatterChartExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Charts.ScatterChartExtensionList? CreateModelElement(ScatterChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ScatterChartExtensionList();
      value.ScatterChartExtensions = GetScatterChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.ScatterChartExtensionList? value)
    where OpenXmlElementType : ScatterChartExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetScatterChartExtensions(openXmlElement, value?.ScatterChartExtensions);
      return openXmlElement;
    }
    return default;
  }
}