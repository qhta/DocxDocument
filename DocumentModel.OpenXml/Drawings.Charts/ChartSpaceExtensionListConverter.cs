using DocumentModel.Drawings.Charts;
using ChartSpaceExtensionList = DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtensionList;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the ChartSpaceExtensionList Class.
/// </summary>
public static class ChartSpaceExtensionListConverter
{
  public static Collection<ChartSpaceExtension>? GetChartSpaceExtensions(ChartSpaceExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<ChartSpaceExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtension>())
      {
        var newItem = ChartSpaceExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetChartSpaceExtensions(ChartSpaceExtensionList? openXmlElement, Collection<ChartSpaceExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = ChartSpaceExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Charts.ChartSpaceExtensionList? CreateModelElement(ChartSpaceExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ChartSpaceExtensionList();
      value.ChartSpaceExtensions = GetChartSpaceExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.ChartSpaceExtensionList? value)
    where OpenXmlElementType : ChartSpaceExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetChartSpaceExtensions(openXmlElement, value?.ChartSpaceExtensions);
      return openXmlElement;
    }
    return default;
  }
}