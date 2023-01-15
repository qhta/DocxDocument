using DocumentModel.Drawings.Charts;
using StockChartExtensionList = DocumentFormat.OpenXml.Drawing.Charts.StockChartExtensionList;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the StockChartExtensionList Class.
/// </summary>
public static class StockChartExtensionListConverter
{
  public static Collection<StockChartExtension>? GetStockChartExtensions(StockChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<StockChartExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.StockChartExtension>())
      {
        var newItem = StockChartExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetStockChartExtensions(StockChartExtensionList? openXmlElement, Collection<StockChartExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.StockChartExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = StockChartExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.StockChartExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Charts.StockChartExtensionList? CreateModelElement(StockChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.StockChartExtensionList();
      value.StockChartExtensions = GetStockChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.StockChartExtensionList? value)
    where OpenXmlElementType : StockChartExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetStockChartExtensions(openXmlElement, value?.StockChartExtensions);
      return openXmlElement;
    }
    return default;
  }
}