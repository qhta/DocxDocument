using DocumentModel.Drawings.Charts;
using RadarSerExtensionList = DocumentFormat.OpenXml.Drawing.Charts.RadarSerExtensionList;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the RadarSerExtensionList Class.
/// </summary>
public static class RadarSerExtensionListConverter
{
  public static Collection<RadarSerExtension>? GetRadarSerExtensions(RadarSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<RadarSerExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.RadarSerExtension>())
      {
        var newItem = RadarSerExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetRadarSerExtensions(RadarSerExtensionList? openXmlElement, Collection<RadarSerExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.RadarSerExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = RadarSerExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.RadarSerExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Charts.RadarSerExtensionList? CreateModelElement(RadarSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.RadarSerExtensionList();
      value.RadarSerExtensions = GetRadarSerExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.RadarSerExtensionList? value)
    where OpenXmlElementType : RadarSerExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRadarSerExtensions(openXmlElement, value?.RadarSerExtensions);
      return openXmlElement;
    }
    return default;
  }
}