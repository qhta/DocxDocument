using DocumentModel.Drawings.Charts;
using BubbleChartExtensionList = DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtensionList;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the BubbleChartExtensionList Class.
/// </summary>
public static class BubbleChartExtensionListConverter
{
  public static Collection<BubbleChartExtension>? GetBubbleChartExtensions(BubbleChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<BubbleChartExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtension>())
      {
        var newItem = BubbleChartExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetBubbleChartExtensions(BubbleChartExtensionList? openXmlElement, Collection<BubbleChartExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = BubbleChartExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Charts.BubbleChartExtensionList? CreateModelElement(BubbleChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.BubbleChartExtensionList();
      value.BubbleChartExtensions = GetBubbleChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.BubbleChartExtensionList? value)
    where OpenXmlElementType : BubbleChartExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBubbleChartExtensions(openXmlElement, value?.BubbleChartExtensions);
      return openXmlElement;
    }
    return default;
  }
}