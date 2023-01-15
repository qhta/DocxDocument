using DocumentModel.Drawings.Charts;
using RadarChartExtensionList = DocumentFormat.OpenXml.Drawing.Charts.RadarChartExtensionList;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the RadarChartExtensionList Class.
/// </summary>
public static class RadarChartExtensionListConverter
{
  public static Collection<RadarChartExtension>? GetRadarChartExtensions(RadarChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<RadarChartExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.RadarChartExtension>())
      {
        var newItem = RadarChartExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetRadarChartExtensions(RadarChartExtensionList? openXmlElement, Collection<RadarChartExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.RadarChartExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = RadarChartExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.RadarChartExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Charts.RadarChartExtensionList? CreateModelElement(RadarChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.RadarChartExtensionList();
      value.RadarChartExtensions = GetRadarChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.RadarChartExtensionList? value)
    where OpenXmlElementType : RadarChartExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRadarChartExtensions(openXmlElement, value?.RadarChartExtensions);
      return openXmlElement;
    }
    return default;
  }
}