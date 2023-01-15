using DocumentModel.Drawings.Charts;
using BarChartExtensionList = DocumentFormat.OpenXml.Drawing.Charts.BarChartExtensionList;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the BarChartExtensionList Class.
/// </summary>
public static class BarChartExtensionListConverter
{
  public static Collection<BarChartExtension>? GetBarChartExtensions(BarChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<BarChartExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.BarChartExtension>())
      {
        var newItem = BarChartExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetBarChartExtensions(BarChartExtensionList? openXmlElement, Collection<BarChartExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.BarChartExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = BarChartExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BarChartExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Charts.BarChartExtensionList? CreateModelElement(BarChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.BarChartExtensionList();
      value.BarChartExtensions = GetBarChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.BarChartExtensionList? value)
    where OpenXmlElementType : BarChartExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBarChartExtensions(openXmlElement, value?.BarChartExtensions);
      return openXmlElement;
    }
    return default;
  }
}