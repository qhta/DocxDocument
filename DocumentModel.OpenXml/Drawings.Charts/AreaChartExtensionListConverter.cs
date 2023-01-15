using DocumentModel.Drawings.Charts;
using AreaChartExtensionList = DocumentFormat.OpenXml.Drawing.Charts.AreaChartExtensionList;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the AreaChartExtensionList Class.
/// </summary>
public static class AreaChartExtensionListConverter
{
  public static Collection<AreaChartExtension>? GetAreaChartExtensions(AreaChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<AreaChartExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.AreaChartExtension>())
      {
        var newItem = AreaChartExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetAreaChartExtensions(AreaChartExtensionList? openXmlElement, Collection<AreaChartExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.AreaChartExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = AreaChartExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.AreaChartExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Charts.AreaChartExtensionList? CreateModelElement(AreaChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.AreaChartExtensionList();
      value.AreaChartExtensions = GetAreaChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.AreaChartExtensionList? value)
    where OpenXmlElementType : AreaChartExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAreaChartExtensions(openXmlElement, value?.AreaChartExtensions);
      return openXmlElement;
    }
    return default;
  }
}